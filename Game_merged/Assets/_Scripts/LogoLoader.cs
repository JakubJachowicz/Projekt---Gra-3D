using UnityEngine;
using System.Collections;

public class LogoLoader : MonoBehaviour {

	private LevelHandler levelHandler;

	// Use this for initialization
	void Start () {
		StartCoroutine ("Countdown");
		levelHandler = GameObject.FindObjectOfType<LevelHandler>();
	}
	
	private IEnumerator Countdown () {
		yield return new WaitForSeconds(5);
		levelHandler.LoadNextLevel();
	}
}
