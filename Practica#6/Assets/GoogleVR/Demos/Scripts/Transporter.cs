using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transporter : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Entered()
    {
        Debug.Log("Gazed at");
    }

    public void Exited()
    {
        Debug.Log("Gazed off");
    }
}
