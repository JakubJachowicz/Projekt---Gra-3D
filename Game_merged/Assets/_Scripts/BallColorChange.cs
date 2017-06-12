using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallColorChange : MonoBehaviour {

	// Use this for initialization
	void Start () {
		if (PlayerPrefsManager.GetFireColour() == 1)
			GetComponent<Renderer> ().material.color = Color.white;
		if (PlayerPrefsManager.GetFireColour() == 2)
			GetComponent<Renderer> ().material.color = Color.red;
		if (PlayerPrefsManager.GetFireColour() == 3)
			GetComponent<Renderer> ().material.color = Color.yellow;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
