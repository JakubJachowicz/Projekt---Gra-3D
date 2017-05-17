using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementOptions : MonoBehaviour {

	public float movementSpeed = 10f;
	public float rotationSpeed = 50f;

	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.W))
			transform.Translate(Vector3.up * movementSpeed * Time.deltaTime);
		if(Input.GetKey(KeyCode.A))
			transform.Translate(Vector3.left * movementSpeed * Time.deltaTime);
		if(Input.GetKey(KeyCode.D))
			transform.Translate(Vector3.right * movementSpeed * Time.deltaTime);
		if(Input.GetKey(KeyCode.A))
			transform.Rotate(Vector3.left, rotationSpeed * Time.deltaTime);
		if (Input.GetKey(KeyCode.D))
			transform.Rotate(Vector3.right, rotationSpeed * Time.deltaTime);
	}
}
