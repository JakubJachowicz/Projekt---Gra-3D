using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinBehaviour : MonoBehaviour {

	public int coinValue = 1;
	private MovementOptions gameControler;
	public float rotationSpeed = 10f;

	void Start(){
		GameObject gameControlerObject = GameObject.Find("Ball");
		if (gameControlerObject != null) {
			gameControler = gameControlerObject.GetComponent<MovementOptions> ();
		}
		if (gameControler == null) {
			Debug.Log("Błąd!");
		}
	}

	// Update is called once per frame
	void Update () {
		transform.Rotate (Vector3.left * rotationSpeed * Time.deltaTime);
	}

	void OnTriggerEnter(Collider collision) {

		if (collision.gameObject.name != "Ball")
			return;
		Destroy (gameObject);
		gameControler.AddScore (coinValue);
		}
}

