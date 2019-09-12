using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class volume : MonoBehaviour
{

    AudioSource music;
    private bool paused = false;


    // Start is called before the first frame update
    void Start()
    {
        music = GetComponent<AudioSource>();
        music.volume = 0.5F;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.P))
        {
            paused = !paused;
        }

        if (paused)
            music.mute = true;
        else
            music.mute = false;
    }
}
