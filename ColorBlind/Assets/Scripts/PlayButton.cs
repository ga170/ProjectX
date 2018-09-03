using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour {

    // Use this for initialization
    void Start()
    {
        //Resumes the update method
        Time.timeScale = 1;
        //Checks if the song is already playing
        if (AudioManager.instance.IsPlaying("MenuSound")==false)
        {
            AudioManager.instance.Play("MenuSound");

        }

    }

    public void OnPlayClick()
    {
        AudioManager.instance.Stop("MenuSound");
        SceneManager.LoadScene(1);
    }
}
