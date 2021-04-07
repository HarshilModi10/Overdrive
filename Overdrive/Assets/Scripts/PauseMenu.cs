using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PauseMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void pause(){
        Time.timeScale = 0f;
        gameObject.SetActive(true);
    }

    public void resume(){
        Time.timeScale = 1;
        gameObject.SetActive(false);
    }

    public void returnToMainMenu(){
        SceneManager.LoadScene("Menu");
    }

    public void returnToStartGameMenu(){
        SceneManager.LoadScene("StartGame");
    }
}