using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class Pauser : MonoBehaviour {
	[SerializeField] private bool muted = false;
	[SerializeField] private bool paused = false;
	[SerializeField] private GameObject pauseMenu;
	[SerializeField] private AudioSource music;

	// Update is called once per frame
	void Update () {
		if(Input.GetKeyUp(KeyCode.P))
		{
			paused = !paused;
		}

		if(paused){
			music.volume = 0.1F;
			Time.timeScale = 0;
			pauseMenu.SetActive(true);
		}
		else{
			music.volume = 0.5F;
			Time.timeScale = 1;
			pauseMenu.SetActive(false);
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
		SceneManager.LoadScene("Level");
	}
}
