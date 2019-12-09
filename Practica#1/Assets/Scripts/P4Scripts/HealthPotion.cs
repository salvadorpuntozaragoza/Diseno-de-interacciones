using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Healt potion", menuName = "Items/Potions/Healt Potion")]

public class HealthPotion : Item
{
  public override void Use()
    {
        base.Use();
        Debug.Log("Usando pocion de salud");
    }
}
