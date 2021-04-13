using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using static Shop;
using static CosmeticItem;
public class MainMenu : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ToStartGame()
    {
        SceneManager.LoadScene("StartGame");//load Game scene
    }

    public void ToPlayerProfile()
    {
        SceneManager.LoadScene("PlayerProfile");//load PlayerProfile scene
    }

    public void ToShop()
    {
        SceneManager.LoadScene("Shop");//load Shop scene
    }

    public void ToHelp()
    {
        SceneManager.LoadScene("Help");//load Help scene
    }

    public static List<CosmeticItem> getPurchasedCosmetics(){
        if (ShopItems.getPurchasedCosmetics() == null)
        {
            ShopItems.setUp();
        }

        List<CosmeticItem> purchasedCosmeticList = ShopItems.getPurchasedCosmetics();

        return purchasedCosmeticList;
    }

}
