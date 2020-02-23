using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TotalCoinsRecord : MonoBehaviour
{
	public Text totalCoinsRecord;
    // Start is called before the first frame update
    void Start()
    {
		totalCoinsRecord.text = "Total Coins: " + PlayerPrefs.GetInt("TotalCoins");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
