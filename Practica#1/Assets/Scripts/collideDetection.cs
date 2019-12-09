using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collideDetection : MonoBehaviour
{
    [SerializeField] private GameObject text;
    [SerializeField] private AudioSource sfx;

    // Start is called before the first frame update
    void Start()
    {
    }

    void OnTriggerEnter(Collider c){
        if (c.CompareTag("Player"))
        {
            Debug.Log("Collision detected");
            text.SetActive(true);
            sfx.Play();
        }
    }

    void OnTriggerExit(Collider c){
        if (c.CompareTag("Player"))
            text.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
