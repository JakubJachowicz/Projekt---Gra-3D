using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour {

	public int totalCoins = 100;
	public Transform spawnLocation;
	
	public GameObject sphereprefab;
	public Camera cameraprefab;
	public Light lightprefab;
	public GameObject coinprefab;
	
	void Awake(){
		spawnLocation.position = new Vector3(0, 2, 10);
	}
	
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
		GameObject sphere = GameObject.Instantiate(sphereprefab);
		sphere.name = "Sphere";
		sphere.transform.position = transform.position;
		
		Camera  camera = GameObject.Instantiate(cameraprefab);
		CameraBehindSphere cameraController = camera.GetComponent<CameraBehindSphere>();
		cameraController.sphere = sphere.transform;
		
		Light mylight = GameObject.Instantiate(lightprefab);
		LightBehindBall lightController = mylight.GetComponent<LightBehindBall>();
		lightController.sphere = sphere.transform;
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void spawnNewCoin()
	{
		spawnLocation.position = new Vector3 (Random.Range(-2, 3), Random.Range(1, 3), Random.Range(10, 1000));
			/*
			spawnLocation[i].position.x = Random.Range(-2, 3);
			spawnLocation[i].position.y = Random.Range(1, 3);
			spawnLocation[i].position.z = Random.Range(10, 1000);
			*/
			Instantiate(coinprefab, spawnLocation.transform.position, Quaternion.identity);
	}
}

