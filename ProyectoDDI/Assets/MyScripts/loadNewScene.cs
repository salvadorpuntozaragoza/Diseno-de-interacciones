using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadNewScene : MonoBehaviour
{

    
    private string [] scenes = new string[8]{"Scene1Lvl1", "Scene1Lvl2", "Scene1Lvl3", "Scene1Lvl4", "Scene1Lvl5", "Scene1Lvl6", "Scene1Lvl7", "Scene1Lvl8"};
    [SerializeField] private int scene;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider c)
    {
        if(c.CompareTag("Player")){
            SceneManager.LoadScene(scenes[scene]);
            Debug.Log("Loaded");
        }
    }
}
