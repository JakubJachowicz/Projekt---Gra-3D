using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementOptions : MonoBehaviour {
	
	int lane = 0;
	Rigidbody rigidbody;
	
	public float laneWidth = 2.5f;
	public float jumpForce = 500f;
	public float acceleration=0.1f;
	public float maxSpeed=30.0f;
	public float gravityLevel = 9.8f;
	
	private float curSpeed=0.0f;
	private int score = 0;
	void Start() {
		rigidbody = transform.GetComponent<Rigidbody> ();
	}

	void Update() {
		rigidbody.velocity = Vector3.forward * curSpeed;
   		curSpeed += acceleration;
 
    if (curSpeed > maxSpeed)
        curSpeed = maxSpeed;
    
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
		float delta = lane * laneWidth - rigidbody.position.x;
		Vector3 velocity = rigidbody.velocity;
		velocity.x = delta * 3f;
		rigidbody.velocity = velocity;
	}

	void jumping()
	{
		bool isOnGround = Physics.Raycast (transform.position, Vector3.down, 1f);
		Vector3 direction = Vector3.zero;
		if (Input.GetKeyDown (KeyCode.W))
			direction = Vector3.up;
		if(isOnGround)
			rigidbody.AddForce (direction * jumpForce);
		if(!isOnGround)
		{
			Vector3 vel = rigidbody.velocity;
			vel.y = -3*gravityLevel*Time.deltaTime;
			rigidbody.velocity = vel;
		}
	}

	public void AddScore(int newScoreValue){
		score += newScoreValue;
		Debug.Log ("Monety: " + score);
	}
}