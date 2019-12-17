using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class smallWall : MonoBehaviour
{
    // Start is called before the first frame update
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
            c.GetComponent<Rigidbody>().AddForce(Vector3.up * 800);
            Debug.Log("Triggered");
        }
    }
}
