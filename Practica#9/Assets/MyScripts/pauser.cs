using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pauser : MonoBehaviour
{

    [SerializeField] private GameObject pauseMenu;
    [SerializeField] private AudioSource music;
    Scene escena;
    private bool muted;
    private bool paused;
    // Start is called before the first frame update
    void Start()
    {
        //pauseMenu.SetActive(false);
        muted = false;
        paused = false;
        escena = SceneManager.GetActiveScene();
    }

    // Update is called once per frame
    void Update()
    {
        if(paused){
            pauseMenu.SetActive(true);
            music.volume = 0.5f;
            //Time.timeScale = 0.0f;
        }else{
            pauseMenu.SetActive(false);
            music.volume = 1.0f;
            //Time.timeScale = 1.0f;
        }
    }

    public void mute(){
        muted = !muted;
        if(muted){
            Debug.Log("Muted");
            music.volume = 0.0f;
        }
        else{
            Debug.Log("Un-Muted");
            music.volume = 0.5f;
        }
    }

    public void continuar(){
        paused = false;
    }

    public void reiniciar(){
        music.volume = 1.0f;
        Time.timeScale = 1.0f;
        SceneManager.LoadScene(escena.name);
    }

    public void pause(){
        if(!paused)
            paused = true;
    }

    public void open(bool opened){
        if(opened)
            Debug.Log("Opened");
        if(!opened)
            Debug.Log("Closed");
    }

    void OnTriggerEnter(Collider c)
    {
        if(c.tag == "continue"){
            Debug.Log("Collided with continue");
            continuar();
        }

        if(c.tag.Equals("restart")){
            Debug.Log("Collided with restart");
            reiniciar();
        }

        if(c.tag == "mute"){
            Debug.Log("Collided with mute");
            mute();
        }
    }
}
