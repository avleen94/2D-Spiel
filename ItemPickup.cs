using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : InteractObject
{
    public Item item;

    public override void Interact()
    {
        base.Interact();
        PickUp();
    }

    void PickUp()
    {
        Debug.Log("Picking Up " + item.itemName);
        Inventory.instance.Add(item);
        gameObject.SetActive(false);
        infoText.text = message;
        textbox.SetActive(true);
    }

}
