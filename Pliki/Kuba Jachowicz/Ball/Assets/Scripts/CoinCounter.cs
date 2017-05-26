using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCounter : MonoBehaviour {

	int numberOfCoins = 0;

	void OnTriggerEnter(Collider collision) {

		if (collision.gameObject.name != "Ball")
			return;
		Destroy (gameObject);
		numberOfCoins++;
		Debug.Log ("Licza monet: " + numberOfCoins);
	}
}
