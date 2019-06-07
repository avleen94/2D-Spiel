using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New item", menuName = "Inventory/Item")]

public class Item : ScriptableObject {

	public string itemName = "New Item";
    public Sprite icon = null;
    public string description = " ";
    

    public virtual void Use()
    {
        Debug.Log("Using " + itemName);
    }
}
