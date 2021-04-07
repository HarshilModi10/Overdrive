
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using static ShopItems;
using static CosmeticItem;
public class StartGame : MonoBehaviour
{

    public Dropdown cosmeticItemDropdown;
    private List<CosmeticItem> purchasedCosmeticList;
    // Start is called before the first frame update
    void Start()
    {
        if (ShopItems.getPurchasedCosmetics() == null)
        {
            ShopItems.setUp();
        }
        purchasedCosmeticList = ShopItems.getPurchasedCosmetics();
        
        List<string> options = new List<string>();
        for (int i = 0; i < purchasedCosmeticList.Count; i++) {
            options.Add(purchasedCosmeticList[i].getName());
        }
        cosmeticItemDropdown.ClearOptions();
        cosmeticItemDropdown.AddOptions(options);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     public void ToStage1()
    {
        int cosmeticItem = cosmeticItemDropdown.value;
        PlayerMotor.setPlayerCosmetic(purchasedCosmeticList[cosmeticItem]);
        SceneManager.LoadScene("Game");//load Game scene
    }

    public void ToStage2()
    {
        int cosmeticItem = cosmeticItemDropdown.value;
        PlayerMotor.setPlayerCosmetic(purchasedCosmeticList[cosmeticItem]);
        SceneManager.LoadScene("Game2");//load Game scene
    }

    public void ToStage3()
    {
        int cosmeticItem = cosmeticItemDropdown.value;
        PlayerMotor.setPlayerCosmetic(purchasedCosmeticList[cosmeticItem]);
        SceneManager.LoadScene("Game3");//load Game scene
    }

    public void ToStage4()
    {
        int cosmeticItem = cosmeticItemDropdown.value;
        PlayerMotor.setPlayerCosmetic(purchasedCosmeticList[cosmeticItem]);
        SceneManager.LoadScene("Game4");//load Game scene
    }

    public void ToMenu()
    {
        SceneManager.LoadScene("Menu");//load Game scene
    }
}
