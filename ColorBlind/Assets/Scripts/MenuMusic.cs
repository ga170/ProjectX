using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuMusic : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
    }

    //Returns to the home screen
    public void HomePage()
    {
    SceneManager.LoadScene(0);
    }

    //Reloads the level
    public void ReloadScene()
    {
        //Resumes the update method
        Time.timeScale = 1;
        //Stops the Menu song
        AudioManager.instance.Stop("MenuSound");
        SceneManager.LoadScene(1);
    }

    //Plays the forward Sound
    public void OnClickForwardSound()
    {
        //Plays the forward sound
        AudioManager.instance.Play("Forward");
    }

    //Plays the back sound
    public void OnClickBackSound()
    {
        //Plays the back sound
        AudioManager.instance.Play("Back");
    }



}
