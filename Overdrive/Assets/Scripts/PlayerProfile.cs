using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using static PlayerProfileData;

public class PlayerProfile : MonoBehaviour
{
    // Start is called before the first frame update
    public Text availableOdCoinsText;
    public Text avgOdCoinsEarnedText;
    public Text avgStageDurationText;

    void Start()
    {

        availableOdCoinsText.text = "Available OD Coins: " + PlayerProfileData.getAvailableOdCoins();
        avgOdCoinsEarnedText.text = "Average OD Coins Earned Per Game : " + calculateAverageCoinsEarned();
        avgStageDurationText.text = "Average Duration Per Game: " + calculateAverageStageDuration();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ToMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    private int calculateAverageCoinsEarned(){
        return (int) PlayerProfileData.getTotalOdCoinsEarned()/PlayerProfileData.getTotalStagesPlayed();

    }

    private int calculateAverageStageDuration(){
        return (int) PlayerProfileData.getSumOfGameDurations()/PlayerProfileData.getTotalStagesPlayed();
    }
}
