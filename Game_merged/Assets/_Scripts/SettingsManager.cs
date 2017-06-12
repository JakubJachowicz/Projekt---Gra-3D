using UnityEngine;
 using UnityEngine.UI;
 using System.Collections;
 
 public class SettingsManager : MonoBehaviour {

     public Slider volumeSlider;
     public Slider difficultySlider;
	 public LevelHandler levelHandler;

	 public Toggle whiteToggle;
	 public Toggle redToggle;
	 public Toggle blueToggle;

	 private int fireColorIndex;
 	
     // Use this for initialization
     void Start () {
     	fireColorIndex = PlayerPrefsManager.GetFireColour();
        volumeSlider.value = AudioListener.volume;
        if 		(fireColorIndex == 0) { fireColorIndex = 1; }
        if 		(fireColorIndex == 1) { whiteToggle.isOn = true; } 
		else if (fireColorIndex == 2) { redToggle.isOn = true; }
		else if (fireColorIndex == 3) { blueToggle.isOn = true; }
     }



     // Update is called once per frame
     void Update () {
		AudioListener.volume = volumeSlider.value;
		PlayerPrefsManager.SetMasterVolume (volumeSlider.value);
		if 		(whiteToggle.isOn == true) 	{ PlayerPrefsManager.SetFireColour(1); } 
		else if (redToggle.isOn == true) 	{ PlayerPrefsManager.SetFireColour(2); } 
		else if (blueToggle.isOn == true) 	{ PlayerPrefsManager.SetFireColour(3); } 
     }
 
     public void SaveAndExit () {
		levelHandler.LoadLevel ("Start");
     }
 }