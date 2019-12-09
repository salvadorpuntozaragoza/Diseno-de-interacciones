using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingPlatform : MonoBehaviour
{

    [SerializeField] private float minHeight, maxHeight, maxDist;
    private bool move;
    [SerializeField] private bool goUp;
    [SerializeField] private bool goForw;
    // Start is called before the first frame update
    void Start()
    {
        move = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(goUp && transform.position.y < maxHeight && move)
            transform.position += transform.TransformDirection(new Vector3(0,1,0)) * Time.deltaTime * 5f;
    
        if(goForw && transform.position.x < maxDist && move){
            transform.position += transform.TransformDirection(new Vector3(1,0,0)) * Time.deltaTime * 5f;
            Debug.Log(transform.position.x);
        }
    }


    void OnTriggerEnter(Collider c)
    {
        if(c.tag == "Player"){
            move = true;
        }
    }
}
