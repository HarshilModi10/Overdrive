using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopItems : MonoBehaviour
{
    private List<CosmeticItem> purchasedCosmeticList;
    private List<CosmeticItem> allCosmeticList;
    // Start is called before the first frame update
    void Start()
    {
        this.purchasedCosmeticList = new List<CosmeticItem>();
        Mesh mesh = Resources.GetBuiltinResource<Mesh>("Cube.fbx");
        CosmeticItem test = new CosmeticItem("item1",mesh, 1000);
        this.purchasedCosmeticList.Add(test);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public List<CosmeticItem> getPurchasedCosmetics(){
        //try{
            return this.purchasedCosmeticList;
        //}catch{
        //    return (this.purchasedCosmeticList.);
        //}
        
    }

    public List<CosmeticItem> getAllCosmetics(){
        return this.allCosmeticList;
    }
}
