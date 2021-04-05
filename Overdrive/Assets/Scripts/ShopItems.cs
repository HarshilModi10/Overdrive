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

    public List<CosmeticItem> getAllCosmetics(){
        return allCosmeticList;
    }

    public static void setUp()
    {
        purchasedCosmeticList = new List<CosmeticItem>();
        allCosmeticList = new List<CosmeticItem>();

        Mesh mesh = Resources.GetBuiltinResource<Mesh>("Cube.fbx");
        CosmeticItem cube = new CosmeticItem("Cube", mesh, 1000);
        purchasedCosmeticList.Add(cube);
        allCosmeticList.Add(cube);

        mesh = Resources.GetBuiltinResource<Mesh>("Capsule.fbx");
        CosmeticItem capsule = new CosmeticItem("Capsule", mesh, 1000);
        purchasedCosmeticList.Add(capsule); //COMMENT THIS OUT ONCE SELECTION WORKS FOR SURE
        allCosmeticList.Add(capsule);

        mesh = Resources.GetBuiltinResource<Mesh>("Sphere.fbx");
        CosmeticItem sphere = new CosmeticItem("Sphere", mesh, 1000);
        purchasedCosmeticList.Add(sphere); //COMMENT THIS OUT ONCE SELECTION WORKS FOR SURE
        allCosmeticList.Add(sphere);
    }
}
