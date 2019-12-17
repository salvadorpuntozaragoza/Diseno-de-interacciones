using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class edgeLauncher : MonoBehaviour
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
        if(c.CompareTag("Player")){
            c.GetComponent<Rigidbody>().AddForce(new Vector3(1,1,0) * 500);
        }
    }
}
