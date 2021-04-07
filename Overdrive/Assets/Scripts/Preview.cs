using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Preview : MonoBehaviour
{
    public Text odCoinText;
    public Text characterTitleText;
    public Text characterCostText;
    public Button purchaseButton;

    private float availableOdCoins;

    private static CosmeticItem character;

    private Mesh characterMesh;

    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {   
        availableOdCoins = PlayerPrefs.GetFloat("availableOdCoins");

        //populate text
        odCoinText.text = "OD Coins: " + availableOdCoins;
        characterTitleText.text = character.getName();
        characterCostText.text = "COST: " + character.getPrice().ToString() + " OD Coins";

        //object preview
        characterMesh = Resources.GetBuiltinResource<Mesh>(character.getName() + ".fbx");
        player.GetComponent<MeshFilter>().mesh = characterMesh;

        //determine if purchase button is enabled
        if (availableOdCoins >= character.getPrice() && PlayerPrefs.GetInt(character.getName() + "Purchased") == 0) {
            purchaseButton.interactable = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ToShop() {
        SceneManager.LoadScene("Shop");
    }

    public static void setPreviewCosmetic(CosmeticItem cosmetic) {
        character = cosmetic;
    }

    public void purchaseItem() {
        PlayerPrefs.SetInt(character.getName() + "Purchased", 1);
        PlayerPrefs.SetFloat("availableOdCoins", availableOdCoins - character.getPrice());
        ShopItems.purchaseCosmetic(character);
        SceneManager.LoadScene("Shop");
    }
}
