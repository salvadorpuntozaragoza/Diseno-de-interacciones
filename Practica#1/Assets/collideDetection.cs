using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collideDetection : MonoBehaviour
{

  [SerializeField] private bool entered;
    // Start is called before the first frame update
    void Start()
    {
      entered = false;
    }

    void OnTriggerEntered(Collider c){
      entered = true;
    }

    void OnTriggerExited(Collider c){
      entered = false;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
