using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightBehindBall : MonoBehaviour {

	public Transform sphere;

	// Update is called once per frame
	void Update () {

		Vector3 vector = sphere.position + new Vector3 (0, 7f, -2f);
		transform.position = Vector3.Lerp(transform.position, vector, Time.deltaTime*10);
	}
}
