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
        try
        {
            availableOdCoinsText.text = "Available OD Coins: " + PlayerPrefs.GetFloat("availableOdCoins");
            avgOdCoinsEarned.text = "Average  OD Coins Earned Per Game : " + PlayerPrefs.GetFloat("totalOdCoinsEarned") / PlayerPrefs.GetFloat("totalStagesPlayed");
            avgStageDuration.text = "Average  Duration Per Game " + (int)(PlayerPrefs.GetFloat("sumOfGameDurations") / PlayerPrefs.GetFloat("totalStagesPlayed"));
        } catch
        {
            PlayerPrefs.SetFloat("availableOdCoins", 0);
            PlayerPrefs.SetFloat("totalOdCoinsEarned", 0);
            PlayerPrefs.SetFloat("totalStagesPlayed", 0);
            PlayerPrefs.SetFloat("sumOfGameDurations", 0);
        }
        print(PlayerPrefs.GetFloat("availableOdCoins"));
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
