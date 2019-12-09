using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Interactablep5 : MonoBehaviour
{
	bool isInsideZone;
	//public KeyCode interactionKey = KeyCode.I;
	//public string buttonName =  "Interact";

	/// <summary>
	/// Update is called every frame, if the MonoBehaviour is enabled.
	/// </summary>
	void Update()
	{
		if(isInsideZone)
		{
            
			if(CrossPlatformInputManager.GetButtonDown("Interact"))
			{
                Debug.Log("Interact button pressed");
				Interact();
			}
		}
	}

//Intercat: name
//possitive button: I

//second stick
//hopriozntal axis name : Mouse X
//vertical axis name: Mouse Y

//second button: intercact button

	/// <summary>
	/// OnTriggerEnter is called when the Collider other enters the trigger.
	/// </summary>
	/// <param name="other">The other Collider involved in this collision.</param>
	void OnTriggerEnter(Collider other)
	{
		if(!other.CompareTag("Player"))
			return;
		// Debug.Log("Entraste en la esfera!");
		// rend.material.color = newColor;
		isInsideZone = true;
	}

	/// <summary>
	/// OnTriggerExit is called when the Collider other has stopped touching the trigger.
	/// </summary>
	/// <param name="other">The other Collider involved in this collision.</param>
	void OnTriggerExit(Collider other)
	{
		isInsideZone = false;
	}

	public virtual void Interact()
	{

	}
}
