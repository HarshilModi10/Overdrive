using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerProfile : MonoBehaviour
{
    // Start is called before the first frame update
    public Text availableOdCoinsText;
    public Text avgOdCoinsEarnedText;
    public Text avgStageDurationText;

    private float availableOdCoins = 0.0f;
    private float totalOdCoinsEarned = 0.0f;
    private float sumOfGameDurations = 0.0f;
    private float totalStagesPlayed = 0.0f;
    private float avgDuration = 0.0f;
    private float avgOdCoinsEarned = 0.0f;


    void Start()
    {

        try
        {
            availableOdCoins = PlayerPrefs.GetFloat("availableOdCoins");
            totalOdCoinsEarned = PlayerPrefs.GetFloat("totalOdCoinsEarned");
            sumOfGameDurations = PlayerPrefs.GetFloat("sumOfGameDurations");
            totalStagesPlayed = PlayerPrefs.GetFloat("totalStagesPlayed");
            avgDuration = (int) (sumOfGameDurations / totalStagesPlayed);
            avgOdCoinsEarned = (int) (totalOdCoinsEarned / totalStagesPlayed);

        } catch {
             print("No PlayerPrepfs: PlayerProfile");
        }

        availableOdCoinsText.text = "Available OD Coins: " + availableOdCoins;
        avgOdCoinsEarnedText.text = "Average  OD Coins Earned Per Game : " + avgOdCoinsEarned;
        avgStageDurationText.text = "Average  Duration Per Game: " + avgDuration;
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
