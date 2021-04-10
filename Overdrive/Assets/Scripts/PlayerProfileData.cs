using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using static System.Math;

public class PlayerProfileData : MonoBehaviour
{


    // Start is called before the first frame update
	public static int getAvailableOdCoins(){
		try{
			return  (int) PlayerPrefs.GetFloat("availableOdCoins");
		} catch {}
		return 0;
	}

	public static int getTotalOdCoinsEarned(){
		try{
			return  (int)PlayerPrefs.GetFloat("totalOdCoinsEarned");
		} catch {}
		return 0;
	}

	public static int getSumOfGameDurations(){
		try{
			return  (int) PlayerPrefs.GetFloat("sumOfGameDurations");
		} catch {}
		return 0;
	}
	public static int getTotalStagesPlayed(){
		try{
			int time = (int) PlayerPrefs.GetFloat("totalStagesPlayed");
			if (time < 1){
				return 1;
			}
			return time;
		} catch {}
		return 1;
	}

}
