using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyTrigger : MonoBehaviour
{

    private bool isInside;
    [SerializeField] private GameObject wall;
    // Start is called before the first frame update
    void Start()
    {
        isInside = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            isInside = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isInside = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(isInside)
        {
            if (Input.GetKeyUp(KeyCode.F))
            {
                wall.SetActive(false);
            }
        }
    }
}
