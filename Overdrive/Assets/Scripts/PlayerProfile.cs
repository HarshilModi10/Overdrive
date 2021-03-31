using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerProfile : MonoBehaviour
{
    // Start is called before the first frame update
    public Text availableOdCoinsText;
    public Text avgOdCoinsEarned;
    public Text avgStageDuration;
    void Start()
    {
   
        availableOdCoinsText.text = "Available OD Coins: " + PlayerPrefs.GetFloat("availableOdCoins");
        avgOdCoinsEarned.text = "Average  OD Coins Earned Per Game : " + PlayerPrefs.GetFloat("totalOdCoinsEarned") / PlayerPrefs.GetFloat("totalStagesPlayed");
        avgStageDuration.text = "Average  Duration Per Game " + (int) (PlayerPrefs.GetFloat("sumOfGameDurations") / PlayerPrefs.GetFloat("totalStagesPlayed"));
    
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
