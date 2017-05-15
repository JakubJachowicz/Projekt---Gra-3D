using UnityEngine;
using System.Collections;

public class LevelHandler : MonoBehaviour {


	void Start () {
	
	}
	

	
	public void ChangeScene (string name) {
		Debug.Log ("Change scene requested");
		Application.LoadLevel(name);
	}
	
	public void QuiyRequest () {
		Debug.Log ("Quit game requested");
		Application.Quit();
	}
}
