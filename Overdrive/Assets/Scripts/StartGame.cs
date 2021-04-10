
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
    public Dropdown stageDropdown;
    private List<CosmeticItem> purchasedCosmeticList;
    private List<string> scenes;

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

        //populate stage information
        int sceneCount = UnityEngine.SceneManagement.SceneManager.sceneCountInBuildSettings;     
        scenes = new  List<string>();
        for( int i = 0; i < sceneCount; i++ )
        {   
            string sceneTitle = System.IO.Path.GetFileNameWithoutExtension( UnityEngine.SceneManagement.SceneUtility.GetScenePathByBuildIndex( i ) );
            if (sceneTitle.Length >= 6 && sceneTitle.Substring(0, 6) == "STAGE_") {
                scenes.Add(sceneTitle.Substring(6));
            }
        }

        stageDropdown.ClearOptions();
        stageDropdown.AddOptions(scenes);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ToMenu()
    {
        SceneManager.LoadScene("Menu");//load Main Menu scene
    }

    public void ToGame() {
        int selectedStage = stageDropdown.value;
        int cosmeticItem = cosmeticItemDropdown.value;
        PlayerMotor.setPlayerCosmetic(purchasedCosmeticList[cosmeticItem]);
        SceneManager.LoadScene("STAGE_" + scenes[selectedStage]);
    }
}

