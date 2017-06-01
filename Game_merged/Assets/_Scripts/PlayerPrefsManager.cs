using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefsManager : MonoBehaviour {
 
     const string MASTER_VOLUME_KEY = "master_volume";
     const string HIGH_SCORE = "High Score";
 
     public static void SetMasterVolume (float volume) {
         if (volume >= 0f && volume <= 1f) {
             PlayerPrefs.SetFloat ("master_volume", volume);
         } else {
             Debug.LogError ("Master Volume out of range");
         }
     }
 
     public static float GetMasterVolume () {
         return PlayerPrefs.GetFloat (MASTER_VOLUME_KEY);
     }
 
     public static void SetHighScore (int score) {
         PlayerPrefs.SetInt (HIGH_SCORE, score);
     }
 
     public static int GetHighScore () {
         return PlayerPrefs.GetInt (HIGH_SCORE);
     }
 }
