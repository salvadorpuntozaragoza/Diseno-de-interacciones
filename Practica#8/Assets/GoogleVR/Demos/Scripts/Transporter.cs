using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transporter : MonoBehaviour
{

    [SerializeField] private float distance;
    [SerializeField] private GameObject player;
    private bool isGazed;
    [SerializeField] private GameObject movementTile;
    // Start is called before the first frame update
    void Start()
    {
        distance = 5f;
        isGazed = false; 
    }

    // Update is called once per frame
    void Update()
    {
        if (isGazed)
        {
            player.transform.position = player.transform.position + Camera.main.transform.forward *
                distance * Time.deltaTime;
            player.transform.position = new Vector3(player.transform.position.x, 1.9f, player.transform.position.z);
        }

        //movementTile.transform.position = Camera.main.transform.position;
        movementTile.transform.position = new Vector3(Camera.main.transform.position.x, 1.2f, Camera.main.transform.position.z);
    }

    public void Entered()
    {
        isGazed = true;
    }

    public void Exited()
    {
        isGazed = false;
    }
}
