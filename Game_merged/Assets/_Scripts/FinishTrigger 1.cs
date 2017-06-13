using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishTrigger : MonoBehaviour {

    private LevelHandler levelHandler;
    public GameObject sphere;

	// Use this for initialization
	void Start () {
        levelHandler = GameObject.FindObjectOfType<LevelHandler>();
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    private void OnTriggerEnter(Collider other)
    {
        MovementOptions script = sphere.GetComponent<MovementOptions>();
        int highScore = script.score;
        PlayerPrefsManager.SetHighScore(highScore);
        if(other.name == "Sphere")
         levelHandler.LoadLevel("GameOver");
    }
}
