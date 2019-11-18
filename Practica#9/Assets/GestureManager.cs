using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestureManager : MonoBehaviour
{

    [SerializeField] private GameObject inventory;
    // Start is called before the first frame update
    void Start()
    {
        inventory.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setInventory(bool state){
        this.inventory.SetActive(state);
    }
}
