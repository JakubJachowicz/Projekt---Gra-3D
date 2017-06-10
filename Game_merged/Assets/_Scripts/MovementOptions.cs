using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovementOptions : MonoBehaviour {
	
	
	int lane = 0;
	Rigidbody rigidbody;
	
	public float laneWidth = 3f;
	public float acceleration = 0.08f;
	public float maxSpeed = 15.0f;
	public Text counterText;
	
	private float curSpeed=1.0f;
	private int score = 0;
	void Start() {
		rigidbody = transform.GetComponent<Rigidbody> ();
		counterText.text = "Liczba monet: " + score.ToString();
	}

	void Update() {
		rigidbody.velocity = Vector3.Lerp(Vector3.forward * 3f, Vector3.forward*(curSpeed<3f ? 3f : curSpeed), 0.5f);
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
		if(isOnGround && Input.GetKeyDown (KeyCode.W))
		{
			Vector3 veloc = rigidbody.velocity;
			veloc = new Vector3(rigidbody.velocity.x, 80f, 7f);
			int counter;
			if (rigidbody.velocity.z < 5)
				counter = 2;
			else if (rigidbody.velocity.z < 7)
				counter = 3;
			else if (rigidbody.velocity.z < 9)
				counter = 4;
			else
				counter = 5;
			rigidbody.velocity = Vector3.Lerp(rigidbody.velocity, veloc, counter/rigidbody.velocity.z);
		}
			
	
		if(!isOnGround)
		{
			Vector3 vel = rigidbody.velocity;
			int counter;
			if (rigidbody.velocity.z < 6)
				counter = 2;
			else if (rigidbody.velocity.z < 9)
				counter = 3;
			else if (rigidbody.velocity.z < 11)
				counter = 4;
			else
				counter = 5;
			vel = new Vector3(rigidbody.velocity.x, -16f, 7f);
			rigidbody.velocity = Vector3.Lerp(rigidbody.velocity, vel, counter/rigidbody.velocity.z);
		}
		
	}

	public void AddScore(int newScoreValue){
		score += newScoreValue;
		counterText.text = "Liczba monet: " + score.ToString();
	}
}