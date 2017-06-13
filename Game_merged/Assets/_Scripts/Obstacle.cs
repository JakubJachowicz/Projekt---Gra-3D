﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour {
	
	private MovementOptions gameControler;
	
	void OnTriggerEnter(Collider collision) {

        if (collision.gameObject.name != "Sphere")
			Application.LoadLevel("Game Over");
		}
}
