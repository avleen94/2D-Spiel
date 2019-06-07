using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseLight : MonoBehaviour {

    public Light lightSource;
    public Item item;

   
    public void Use()
    {
        if(Inventory.instance.items.Contains(item))
        {
            lightSource.enabled = !lightSource.enabled;
        }
        
        
    }
}
