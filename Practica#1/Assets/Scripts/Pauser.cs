using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using UnityStandardAssets.Characters.FirstPerson;
using UnityStandardAssets.CrossPlatformInput;

public class Pauser : MonoBehaviour {
    [SerializeField] private bool muted = false;
    [SerializeField] private bool paused = false;
    [SerializeField] private GameObject pauseMenu;
    [SerializeField] private GameObject HUD;
    [SerializeField] private AudioSource music;
    [SerializeField] private GameObject fps;
    [SerializeField] private MouseLook mouse;
    [SerializeField] private GameObject cam;
    [SerializeField] private GameObject movilInterface;

    private void Start()
    {
        //mouse.lockCursor = true;
    }

    // Update is called once per frame
    void Update () {
		if(CrossPlatformInputManager.GetButtonDown("Pause"))
		{
			paused = !paused;
		}

		if(paused){
            //movilInterface.SetActive(false);
			music.volume = 0.1F;
			Time.timeScale = 0;
			pauseMenu.SetActive(true);
			//HUD.SetActive(false);
            //mouse.lockCursor = false;
            //cam.SetActive(false);
		}
		else{
            //movilInterface.SetActive(true);
			music.volume = 0.5F;
			Time.timeScale = 1;
			pauseMenu.SetActive(false);
			//HUD.SetActive(true);
            //mouse.lockCursor = true;
            //cam.SetActive(true);
		}
	}

	public void Resume(){
		paused = false;
	}

	public void Mute(){
		muted = !muted;

		if(muted)
			music.mute = true;
		else
			music.mute = false;
	}

	public void Restart(){
		SceneManager.LoadScene("InventoryScene");
	}
}
