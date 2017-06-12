using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishTrigger : MonoBehaviour {

    private LevelHandler levelHandler;


	// Use this for initialization
	void Start () {
        levelHandler = GameObject.FindObjectOfType<LevelHandler>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "Sphere")
         levelHandler.LoadLevel("Win");
    }
}
