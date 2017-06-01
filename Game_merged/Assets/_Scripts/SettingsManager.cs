using UnityEngine;
 using UnityEngine.UI;
 using System.Collections;
 
 public class SettingsManager : MonoBehaviour {
 
     public Slider volumeSlider;
     public Slider difficultySlider;
	 public LevelHandler levelHandler;
 
	private MusicPlayer musicPlayer;
     // Use this for initialization
     void Start () {
		 musicPlayer = GameObject.FindObjectOfType<MusicPlayer> ();
         volumeSlider.value = AudioListener.volume;
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