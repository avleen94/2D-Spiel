using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour {

    public Item item;
    public Image icon;
    public Text description;

    public void AddItem(Item newItem)
    {
        item = newItem;

        icon.sprite = item.icon;
        icon.enabled = true;
        description.text = item.description;
    }

    public void ClearSlot()
    {
        item = null;
        icon.sprite = null;
        icon.enabled = false;
        description.text = null;
    }

    public void UseItem()
    {
        if (item != null)
        {
            item.Use();
        }
    }

  

    


}
