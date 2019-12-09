using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using UnityStandardAssets.Characters.FirstPerson;
using UnityStandardAssets.CrossPlatformInput;

public class PauserP3 : MonoBehaviour {
    private bool muted = false;
    private bool paused = false;
    [SerializeField] private GameObject pauseMenu;
    [SerializeField] private AudioSource music;
    [SerializeField] private GameObject hud;
    //[SerializeField] private GameObject movilInterface;

    private void Start()
    {
        //mouse.lockCursor = true;
        Time.timeScale = 1;
        pauseMenu.SetActive(false);
        hud.SetActive(true);
    }

    // Update is called once per frame
    void Update () {
		//if(CrossPlatformInputManager.GetButtonDown("Pause"))
        if(Input.GetKeyDown(KeyCode.P))
		{
            Debug.Log("Pause button clicked");
			paused = !paused;
            updateInterfaces();
		}
	}

    void updateInterfaces()
    {
        if (paused)
        {
            //movilInterface.SetActive(false);
            music.volume = 0.1F;
            Time.timeScale = 0;
            pauseMenu.SetActive(true);
            hud.SetActive(false);
        }
        else
        {
            //movilInterface.SetActive(true);
            music.volume = 0.5F;
            Time.timeScale = 1;
            pauseMenu.SetActive(false);
            hud.SetActive(true);
        }
    }

	public void Resume(){
		paused = false;
        updateInterfaces();
	}

	public void Mute(){
		muted = !muted;

		if(muted)
			music.mute = true;
		else
			music.mute = false;
	}

	public void Restart(){
		SceneManager.LoadScene("Practica #3");
	}
}
