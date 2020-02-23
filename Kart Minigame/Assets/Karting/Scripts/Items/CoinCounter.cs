using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinCounter : MonoBehaviour
{
	public TextMeshProUGUI Coins;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		Coins.text = ("Coins: " + PlayerPrefs.GetInt("Coins"));
    }
}
