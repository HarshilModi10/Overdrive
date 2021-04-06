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

    public void Restart()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().name);//Loads scene over again 
        SceneManager.LoadScene("Game");//Loads scene over again 
        gameObject.SetActive(false);
    }

    public void Restart2()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().name);//Loads scene over again 
        SceneManager.LoadScene("Game2");//Loads scene over again 
        gameObject.SetActive(false);
    }

    public void Restart3()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().name);//Loads scene over again 
        SceneManager.LoadScene("Game3");//Loads scene over again 
        gameObject.SetActive(false);
    }

    public void Restart4()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().name);//Loads scene over again 
        SceneManager.LoadScene("Game4");//Loads scene over again 
        gameObject.SetActive(false);
    }

    public void ToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
