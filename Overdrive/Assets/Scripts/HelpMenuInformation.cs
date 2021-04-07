using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HelpMenuInformation : MonoBehaviour

{
    private static string gameInstuctions = @"This is an infinite runner game with multiple stages. Each stage is unique and allows you to earn Od coins which you you redeem in the shop for another character. You can also check you stats in the player profile menu.";

    private static string gameControls = @"Right key: move right & Left Key: move left";

    public static string getGameInstructions(){
        return gameInstuctions;
    }

    public static string getGameControls(){
        return gameControls;
    }
}
