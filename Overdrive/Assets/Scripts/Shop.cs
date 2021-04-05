using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using static ShopItems;
using static Preview;

public class Shop : MonoBehaviour
{
    public Dropdown shopDropdown;

    public Text odCoinText;

    private List<CosmeticItem> availableCosmeticsList;

    // Start is called before the first frame update
    void Start()
    {
        if (ShopItems.getPurchasedCosmetics() == null)
        {
            ShopItems.setUp();
        }

        //populate purchased and not-purchased characters into dropdown selection menu
        availableCosmeticsList = ShopItems.getAllCosmetics();
        List<string> options = new List<string>();
        for (int i = 0; i < availableCosmeticsList.Count; i++) {
            options.Add(availableCosmeticsList[i].getName());
        }
        shopDropdown.ClearOptions();
        shopDropdown.AddOptions(options);

        //get current available OD Coins
        odCoinText.text = "OD Coins: " + PlayerPrefs.GetFloat("availableOdCoins");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ToMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void ToPreview() {
        int previewedItem = shopDropdown.value;
        Preview.setPreviewCosmetic(availableCosmeticsList[previewedItem]);
        SceneManager.LoadScene("Preview");
    }
}
