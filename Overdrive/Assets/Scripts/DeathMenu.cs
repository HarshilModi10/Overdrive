using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using UnityEngine.SceneManagement;

public class DeathMenu : MonoBehaviour
{
    public Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false); //doesnt display death menu when first launching the game
    }

    // Update is called once per frame
    //void Update()
    //{
        
    //}

    public void ToggleEndMenu(float score)
    {
        gameObject.SetActive(true); //displays death menu
        scoreText.text = ((int)score).ToString();//displays score
    }

    public void ToStartGameMenu() {
        SceneManager.LoadScene("StartGame");
    }

    public void ToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
