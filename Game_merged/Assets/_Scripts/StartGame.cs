using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour {

	private LevelHandler levelHandler;
	// Use this for initialization
	void Start () {
		levelHandler = GameObject.FindObjectOfType<LevelHandler>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.anyKeyDown) {
			levelHandler.LoadLevel("Game");
		}
	}
}
