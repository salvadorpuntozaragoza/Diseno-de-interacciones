using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetected : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
      Debug.Log("Inicia juego");
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision collision){
      Debug.Log("Colision detectadaaaa con " + collision.gameObject.name);
    }
}
