using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{

    [SerializeField] private GameObject jugador;
    private int direction;
    private bool isGazed;
    
    void Start()
    {
        isGazed = false;
        direction = 1;
        Physics.gravity = new Vector3(0,-9.8f,0);    
    }

    void Update()
    {
        if(Input.GetMouseButton(1) && isGazed){
            //Debug.Log("Mouse clicked");
            //float distance = jugador.transform.position.x * 5f * Time.deltaTime + 1f;
            //jugador.transform.position = new Vector3(jugador.transform.position.x + 5f * direction * Time.deltaTime, 1.5f, 0);
            jugador.transform.position += jugador.transform.TransformDirection(new Vector3(1,0,0)) * Time.deltaTime * direction * 5f;
            //jugador.transform.position = jugador.transform.position + Camera.main.transform.forward * 5f * Time.deltaTime;
        }

        if(!jugador.transform.rotation.Equals(new Vector4(0,0,0,1.0f))){
            //Debug.Log(jugador.transform.rotation);
            jugador.transform.rotation = Quaternion.identity;
        }
    }
    public void entered(){
        Debug.Log("Pointer entered");
        isGazed = true;
    }

    public void exited(){
        Debug.Log("Pointer exited");
        isGazed = false;
        direction = 0;
    }

    public void isFacingForward(bool forward){
        if(forward)
            direction = 1;
        else
            direction = -1;

            isGazed = true;
    }
}
