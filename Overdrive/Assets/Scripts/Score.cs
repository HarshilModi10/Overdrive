using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    private float score = 0.0f;

    private int difficultyLevel = 1;
    private int maxDifficultyLevel = 10;
    private int scoreToNextLevel = 10; //start off needing score of 10 to increase level (speed)

    private bool isDead = false;

    public Text scoreText;
    public DeathMenu deathMenu;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isDead)
        {
            return;//exit when dead
        }

        if(score >= scoreToNextLevel)
        {
            LevelUp();
        }
        score += Time.deltaTime * difficultyLevel;
        scoreText.text = ((int)score).ToString(); // turn to int because we dont want float as score
    }

    void LevelUp()
    {
        if(difficultyLevel == maxDifficultyLevel) //level hits max level (speed)
        {
            return;
        }
        scoreToNextLevel *= 2; //every next level(speed) requires twice as many points to increase level(speed)
        difficultyLevel++;
        GetComponent<PlayerMotor>().SetSpeed(difficultyLevel);//sets the new speed in PlayerMotor.cs
        Debug.Log(difficultyLevel);
    }

    public void OnDeath()
    {
        isDead = true;
        float availableOdCoins, totalOdCoinsEarned, totalStagesPlayed;
        totalOdCoinsEarned = totalStagesPlayed = availableOdCoins = 0;
        float sumOfGameDurations = 0;

        try{
            availableOdCoins = PlayerPrefs.GetFloat("availableOdCoins");
            totalOdCoinsEarned = PlayerPrefs.GetFloat("totalOdCoinsEarned");
            totalStagesPlayed = PlayerPrefs.GetFloat("totalStagesPlayed");
            sumOfGameDurations = PlayerPrefs.GetFloat("sumOfGameDurations");
        } catch {}

        float earnedCoins = (int) score / 2;
        PlayerPrefs.SetFloat("availableOdCoins", availableOdCoins + earnedCoins);
        PlayerPrefs.SetFloat("totalOdCoinsEarned", totalOdCoinsEarned + earnedCoins);
        PlayerPrefs.SetFloat("totalStagesPlayed", totalStagesPlayed + 1);
        PlayerPrefs.SetFloat("sumOfGameDurations", sumOfGameDurations + score);
        deathMenu.ToggleEndMenu(score);//turn on death menu
    }
}

