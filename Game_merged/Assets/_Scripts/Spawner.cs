using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {
	
	public int numberOfCoins = 100;
	public GameObject[] coins;
	public GameObject coinPrefab;
    public Light lightprefab;

	// Use this for initialization
	void Start () {
        GameObject sphere = GameObject.Find("Sphere");

		int i;
		int portion = (int)numberOfCoins/3;
		coins = new GameObject[numberOfCoins];
		for (i= 0; i<portion; i++) {
			GameObject singleCoin = Instantiate(coinPrefab, new Vector3(-3, 1, Random.Range(10, 780)), Quaternion.identity) as GameObject;
			coins[i] = singleCoin;
		}
		for (i=portion;i<2*portion;i++) {
			GameObject singleCoin = Instantiate(coinPrefab, new Vector3(0, 1, Random.Range(10, 780)), Quaternion.identity) as GameObject;
			coins[i] = singleCoin;
		}
		for (i=2*portion;i<numberOfCoins;i++) {
			GameObject singleCoin = Instantiate(coinPrefab, new Vector3(3, 1, Random.Range(10, 780)), Quaternion.identity) as GameObject;
			coins[i] = singleCoin;
		}

        Light gameLight = Instantiate(lightprefab, transform.position, Quaternion.identity);
        LightBehindBall lightscript = gameLight.GetComponent<LightBehindBall>();
        lightscript.sphere = sphere.transform;

	}
}
