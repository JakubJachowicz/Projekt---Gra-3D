using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinBehaviour : MonoBehaviour {

	public int coinValue = 1;
	private MovementOptions gameControler;
	public float rotationSpeed = 50f;

	void Start(){
		GameObject gameControlerObject = GameObject.Find("Sphere");
		if (gameControlerObject != null) {
			gameControler = gameControlerObject.GetComponent<MovementOptions> ();
		}
		if (gameControler == null) {
			Debug.Log("Błąd!");
		}
	}

	// Update is called once per frame
	void Update () {
		transform.Rotate (Vector3.forward * rotationSpeed * Time.deltaTime);
	}

	void OnTriggerEnter(Collider collision) {

		if (collision.gameObject.name != "Sphere")
			return;
		Destroy (gameObject);
		gameControler.AddScore (coinValue);
		}
}

