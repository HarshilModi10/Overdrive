using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using static ShopItems;
public class StartGame : MonoBehaviour
{

    public Dropdown cosmeticItemDropdown;
    //private List<CosmeticItem> purchasedCosmeticList;
    // Start is called before the first frame update
    void Start()
    {
        if (ShopItems.getPurchasedCosmetics() == null)
        {
            ShopItems.setUp();
        }
        try
        {
            int cosmeticItem_1 = PlayerPrefs.GetInt("cosmeticItem-1");
        } catch {
            PlayerPrefs.SetInt("cosmeticItem-1", 1);
            int cosmeticItem_1 = PlayerPrefs.GetInt("cosmeticItem-1");
        }
        //SceneManager.LoadSceneAsync("Shop");
        //GameObject ShopObj = GameObject.FindGameObjectWithTag("Shop");
        //print(ShopObj.GetComponent<ShopItems>().getPurchasedCosmetics());
        print(ShopItems.getPurchasedCosmetics());
        //print(this.purchasedCosmeticList.indexOf(0));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     public void ToStage1()
    {
        int cosmeticItem = cosmeticItemDropdown.value;
        print(cosmeticItem);
        PlayerPrefs.SetInt("selectedCosmetic", cosmeticItem);
        SceneManager.LoadScene("Game");//load Game scene
    }
    public void ToMenu()
    {
        SceneManager.LoadScene("Menu");//load Game scene
    }
}
