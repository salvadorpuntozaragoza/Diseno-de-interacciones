using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collides : MonoBehaviour
{

    [SerializeField] GameObject script;
    // Start is called before the first frame update

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    [SerializeField]
    void OnTriggerEnter(Collider c)
    {
        if(c.tag == "continue"){
            Debug.Log("Collided with continue");
        }

        if(c.tag.Equals("restart")){
            Debug.Log("Collided with restart");
        }

        if(c.tag == "mute"){
            Debug.Log("Collided with mute");
        }
        
    }
}
