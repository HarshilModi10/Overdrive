using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ShopItems : MonoBehaviour
{
    private static List<CosmeticItem> purchasedCosmeticList;
    private static List<CosmeticItem> allCosmeticList;
    // Start is called before the first frame update
    void Start()
    {
        setUp();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static List<CosmeticItem> getPurchasedCosmetics(){
        return purchasedCosmeticList;
    }

    public static List<CosmeticItem> getAllCosmetics(){
        return allCosmeticList;
    }

    public static void purchaseCosmetic(CosmeticItem cosmetic) {
        purchasedCosmeticList.Add(cosmetic);
    }

    public static void setUp()
    {
        purchasedCosmeticList = new List<CosmeticItem>();
        allCosmeticList = new List<CosmeticItem>();

        //default, already purchased
        Mesh mesh = Resources.GetBuiltinResource<Mesh>("Cube.fbx");
        CosmeticItem cube = new CosmeticItem("Cube", mesh, 0);
        purchasedCosmeticList.Add(cube);
        allCosmeticList.Add(cube);
        PlayerPrefs.SetInt("CubePurchased", 1);

        mesh = Resources.GetBuiltinResource<Mesh>("Capsule.fbx");
        CosmeticItem capsule = new CosmeticItem("Capsule", mesh, 10);  //CHANGE TO REAL PRICE ONCE SHOP AND COINS FUNCTIONAL
        //purchasedCosmeticList.Add(capsule); //COMMENT THIS OUT ONCE SELECTION WORKS FOR SURE
        allCosmeticList.Add(capsule);
        try {
            if (PlayerPrefs.GetInt("CapsulePurchased") == 1) {
                purchasedCosmeticList.Add(capsule);
            }
        } catch {
            PlayerPrefs.SetInt("CapsulePurchased", 0);
        }

        mesh = Resources.GetBuiltinResource<Mesh>("Sphere.fbx");
        CosmeticItem sphere = new CosmeticItem("Sphere", mesh, 5); //CHANGE TO REAL PRICE ONCE SHOP AND COINS FUNCTIONAL
        //purchasedCosmeticList.Add(sphere); //COMMENT THIS OUT ONCE SELECTION WORKS FOR SURE
        allCosmeticList.Add(sphere);
        try {
            if (PlayerPrefs.GetInt("SpherePurchased") == 1) {
                purchasedCosmeticList.Add(sphere);
            }
        } catch {
            PlayerPrefs.SetInt("SpherePurchased", 0);
        }
    }
    
}
