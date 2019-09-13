using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalReached : MonoBehaviour
{

    [SerializeField] private AudioSource bgMusic;
    [SerializeField] private AudioSource winMusic;
    private bool won;

    // Start is called before the first frame update
    void Start()
    {
        won = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !won)
        {
            bgMusic.Pause();
            winMusic.Play();
            won = true;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
