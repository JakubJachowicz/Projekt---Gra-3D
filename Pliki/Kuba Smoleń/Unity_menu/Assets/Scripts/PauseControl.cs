using UnityEngine;
using System.Collections;

public class PauseControl : MonoBehaviour {

	private GameObject[] pauseObjects;
	
	// Use this for initialization
	void Start () {
		Time.timeScale = 1;
		pauseObjects = GameObject.FindGameObjectsWithTag("ShowOnPause");
		hidePaused();
	}
	
	// Update is called once per frame
	void Update () {
		//press P for pause/unpause
		if(Input.GetKeyDown(KeyCode.P)){
			if (Time.timeScale == 1){
				Debug.Log ("Pause");
				Time.timeScale = 0;
				showPaused();
			} else if (Time.timeScale == 0) {
				Debug.Log ("Unpause");
				Time.timeScale = 1;
				hidePaused();
			}
		}
	}
	
	// show objects with ShowOnPause tag
	private void showPaused() {
		foreach (GameObject g in pauseObjects) {
			g.SetActive(true);
		}
	}
	
	// hide objects with ShowOnPause tag
	private void hidePaused() {
		foreach(GameObject g in pauseObjects){
			g.SetActive(false);
		}
	}
}
