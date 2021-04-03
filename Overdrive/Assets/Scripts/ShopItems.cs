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
        //try{
            return purchasedCosmeticList;
        //}catch{
        //    return (this.purchasedCosmeticList.);
        //}
        
    }

    public List<CosmeticItem> getAllCosmetics(){
        return allCosmeticList;
    }

    public static void setUp()
    {
        purchasedCosmeticList = new List<CosmeticItem>();
        Mesh mesh = Resources.GetBuiltinResource<Mesh>("Cube.fbx");
        CosmeticItem test = new CosmeticItem("item1", mesh, 1000);
        purchasedCosmeticList.Add(test);
        print("TEST");
    }
}
