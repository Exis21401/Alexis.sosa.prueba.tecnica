using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using KartGame.Track;
using UnityEngine.UI;

public class BestLapSave : MonoBehaviour
{
	public Text TextToSet; //Creo una variable de texto a la que asignare el valor de Best time

    void Start()
    {
		TextToSet.text = ("Best time: " + PlayerPrefs.GetString("Best time") + " sec"); //Cogemos la variable Best time y la concatenamos con un string
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	//public float SaveBestLap()
	//{
	//	System.IO.File.WriteAllText("H:/Unity Projects/Kart Minigame/BestTime.txt", trackManager.SessionBestLap.ToString());
	//	return trackManager.SessionBestLap;
	//}
}
