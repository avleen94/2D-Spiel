using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Light", menuName = "Inventory/Light")]

public class ItemLight : Item
{

    public override void Use()
    {
        Debug.Log("Using Light");

        GameManager.instance.spotLight.SetActive(!GameManager.instance.spotLight.activeSelf);
    }
}
