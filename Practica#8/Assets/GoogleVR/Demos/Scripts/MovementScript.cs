using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{

    [SerializeField] private int direction;
    private bool gazedAt;
    [SerializeField] private int speed;
    [SerializeField] private GameObject trans;

    // Start is called before the first frame update
    void Start()
    {
        direction = -1;
        gazedAt = false;
        speed = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (gazedAt)
        {
            
        }
    }

    public void setGazedAt(bool isGazed)
    {
        this.gazedAt = isGazed;
    }
}
