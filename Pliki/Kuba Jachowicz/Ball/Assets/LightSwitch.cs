using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitch : MonoBehaviour {

	public Light myLight;
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("space")) 
		{
			myLight.enabled = !myLight.enabled;
		} 
	}
}
