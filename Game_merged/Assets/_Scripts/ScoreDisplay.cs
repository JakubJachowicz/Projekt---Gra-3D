using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreDisplay : MonoBehaviour {

	public Text scoreDisplayText;

	// Use this for initialization
	void Start () {
		scoreDisplayText.text = PlayerPrefsManager.GetHighScore().ToString();
	}

}
