using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wall : MonoBehaviour
{

    
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
       
    }


    void OnTriggerEnter(Collider c)
    {
        if(c.tag == "Player"){
            c.GetComponent<Rigidbody>().AddForce(Vector3.up * 1000);
            Debug.Log("Triggered");
        }
    }
}
