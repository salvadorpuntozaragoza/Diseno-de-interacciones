using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void start(){
        SceneManager.LoadScene("Scene1Lvl1");
    }

    public void options(){
        Debug.Log("Options");
    }

    public void quit(){
        Debug.Log("Quitted");
        Application.Quit();
    }
}
