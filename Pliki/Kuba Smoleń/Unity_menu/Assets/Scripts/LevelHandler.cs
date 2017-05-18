using UnityEngine;
using System.Collections;

public class LevelHandler : MonoBehaviour {


	void Start () {
	
	}
	
	public void ChangeScene (string name) {
		Debug.Log ("Change scene requested to " + name);
		Application.LoadLevel(name);
	}
	
	public void QuiyRequest () {
		Debug.Log ("Quit game requested");
		Application.Quit();
	}
	
	public void LoadNextLevel () {
		Debug.Log ("Load next scene requested");
		Application.LoadLevel(Application.loadedLevel + 1);
	}
}
