using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackerInfo : MonoBehaviour
{
    [SerializeField] private GameObject hand;
    private int sec = 0, count = 0;
    private float currentHandPositionX;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        count++;
        if(count == 15){
            Swipe();
            currentHandPositionX = hand.transform.position.x;
            count = 0;
        }
        //Debug.Log(hand.transform.position.x);
    }

    void Swipe(){
        if(hand.transform.position.x > (currentHandPositionX + 0.17f)){
            Debug.Log("Swipped");
        }
    }




}
