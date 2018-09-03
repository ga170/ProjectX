using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverMusic : MonoBehaviour {

	// Use this for initialization
	void Start () {
        //Plays the menu song after 1.4 seconds
        AudioManager.instance.PlayDelayed("MenuSound");
	}
	

}
