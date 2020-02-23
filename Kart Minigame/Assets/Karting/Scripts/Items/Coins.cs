using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
	public GameObject Coin;
	public int coins;
	public int totalCoins;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		Coin.transform.Rotate(0,3f,0);
    }

	private void OnTriggerEnter(Collider other)
	{
		coins = (PlayerPrefs.GetInt("Coins") + 1);
		totalCoins = PlayerPrefs.GetInt("TotalCoins");

		PlayerPrefs.SetInt("Coins", coins);
		PlayerPrefs.SetInt("TotalCoins", totalCoins + 1);
		PlayerPrefs.Save();
		Destroy(Coin);
	}
}
