using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour {

	public int totalCoins = 100;
	private Transform spawnLocation;
	public GameObject coinprefab;
	
	// Use this for initialization
	void Start () {
		/*GameObject spawnClone = new  GameObject [spawnLocation.Length];*/
		
		int i;
		for (i=0; i<totalCoins; i++)
		{
			spawnNewCoin();
		}
		/*
		Vector3 * coinPosition = new Vector3 [coinTotal];
		GameObject * coin = new GameObject [coinTotal];
		for (i=0; i<coinTotal;i++)
		{
			coin[i] = GameObject.Instantiate(coinprefab);
		}
		for (i=0; i<coinTotal;i++)
		{
			coinPosition.x = Random.Range(-2, 3);
			coinPosition.y = Random.Range(1, 3);
			coinPosition.z = Random.Range(10, 1000);
			coin[i].transform.position = coinPosition[i];
		}
		*/
	}
	
	void spawnNewCoin()
	{
		spawnLocation.transform.position = new Vector3 (Random.Range(-2, 3), Random.Range(1, 3), Random.Range(10, 1000));
			/*
			spawnLocation[i].position.x = Random.Range(-2, 3);
			spawnLocation[i].position.y = Random.Range(1, 3);
			spawnLocation[i].position.z = Random.Range(10, 1000);
			*/
			Instantiate(coinprefab, spawnLocation.transform.position, Quaternion.identity);
	}
}

