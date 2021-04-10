using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using static HelpMenuInformation;
using UnityEngine.UI;

public class Help : MonoBehaviour

{
    public Text gameInstructionsText;
    public Text gameControlsText;

    void Start()
    {
        gameInstructionsText.text = "Game Instruction: " + HelpMenuInformation.getGameInstructions();
        gameControlsText.text = "Game Controls: " + HelpMenuInformation.getGameControls();
        
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
