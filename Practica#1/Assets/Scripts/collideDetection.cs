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

    void OnTriggerEnter(Collider c){
        Renderer render = GetComponent<Renderer>();
        render.material.color = Color.blue;
    }

    void OnTriggerExit(Collider c){
        Renderer render = GetComponent<Renderer>();
        render.material.color = Color.white;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
