using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementOptions : MonoBehaviour {

	int lane = 0;
	Rigidbody rigidbody;
	public float forwardSpeed = 100f;

	void Start() {
		rigidbody = transform.GetComponent<Rigidbody> ();
	}

	void Update() {
		if (Input.GetKeyDown (KeyCode.Return)) {
			Vector3 startVelocity = rigidbody.velocity;
			startVelocity.z = forwardSpeed*Time.deltaTime;
			rigidbody.velocity = startVelocity;
		}
		switchLane();
		jumping();
	}

	void switchLane()
	{
		if (Input.GetKeyDown (KeyCode.A)) {
			bool isSomething = Physics.Raycast (transform.position, Vector3.left, 2f);
			if (isSomething);
			else if (lane == -1);
			else
				lane--;
		}
		if (Input.GetKeyDown (KeyCode.D)) {
			bool isSomething = Physics.Raycast (transform.position, Vector3.right, 2f);
			if (isSomething);
			else if (lane == 1);
			else
				lane++;
		}
		float delta = lane * 2f - rigidbody.position.x;
		Vector3 velocity = rigidbody.velocity;
		velocity.x = delta * 3f;
		rigidbody.velocity = velocity;
	}

	void jumping()
	{
		Vector3 direction = Vector3.zero;
		if (Input.GetKeyDown (KeyCode.W))
			direction = Vector3.up;
		rigidbody.AddForce (direction * 500f);
	}
}
