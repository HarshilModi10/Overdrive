using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    private List<CosmeticItem> purchasedCosmeticList;
    // Start is called before the first frame update
    void Start()
    {
        this.purchasedCosmeticList = getPurchasedCosmetics();
        print(this.purchasedCosmeticList.indexOf(0));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     public void ToStage1()
    {
        SceneManager.LoadScene("Game");//load Game scene
    }
    public void ToMenu()
    {
        SceneManager.LoadScene("Menu");//load Game scene
    }
}
