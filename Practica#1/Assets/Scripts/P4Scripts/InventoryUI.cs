using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class InventoryUI : MonoBehaviour
{
	public GameObject inventoryPanel;
	private Inventory inventory;

	/// <summary>
	/// Start is called on the frame when a script is enabled just before
	/// any of the Update methods is called the first time.
	/// </summary>
	void Start()
	{
		inventory = FindObjectOfType<Inventory>();
		if (inventory == null)
		{
			Debug.LogWarning("No se encontró el Inventario");
			return;
		}
		inventoryPanel.SetActive(false);
		inventory.onItemChange += UpdateUI;
	}

	/// <summary>
	/// Update is called every frame, if the MonoBehaviour is enabled.
	/// </summary>
	void Update()
	{
		//if(Input.GetKeyDown(KeyCode.Q))
		if(CrossPlatformInputManager.GetButtonDown("Inventory"))
		{
			Debug.Log("UI Off");
            Debug.Log("Inventory button pressed");
			inventoryPanel.SetActive(!inventoryPanel.activeSelf);
            UpdateUI();
		}

        if (CrossPlatformInputManager.GetButtonDown("Pause"))
        {
            Debug.Log("Pause button clicked");
        }

    }

	void UpdateUI()
	{
        Debug.Log("UIUpdated");
		Slot[] slots = GetComponentsInChildren<Slot>();
		for (int i = 0; i < slots.Length; i++)
		{
			if(i < inventory.items.Count)
			{
				slots[i].AddItem(inventory.items[i]);
                Debug.Log("Item added to slot" + i);
			}
			else
			{
				slots[i].ClearSlot();
			}
		}
	}
}
