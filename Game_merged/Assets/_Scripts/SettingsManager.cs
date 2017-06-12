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
 	
     // Use this for initialization
     void Start () {
         volumeSlider.value = AudioListener.volume;
         whiteToggle.isOn = true;
		 redToggle.isOn = false;
		 blueToggle.isOn = false;
     }



     // Update is called once per frame
     void Update () {
		AudioListener.volume = volumeSlider.value;
     }
 
     public void SaveAndExit () {
         PlayerPrefsManager.SetMasterVolume (volumeSlider.value);
		 levelHandler.LoadLevel ("Start");
     }
 }