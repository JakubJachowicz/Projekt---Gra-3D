using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehindSphere : MonoBehaviour {

	public Transform sphere;
	
	// Update is called once per frame
	void Update () {

		Vector3 vector = sphere.position + new Vector3(0, 4f, -8f);
		transform.position = Vector3.Lerp(transform.position, vector, 2*Time.deltaTime);
	}
}
