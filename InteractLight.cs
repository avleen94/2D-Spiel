using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractLight : InteractObject {

    public GameObject lightSource;
    bool isOn;

    public override void Interact()
    {
        if (!isOn)
        {
            sound.Play();
            lightSource.SetActive(true);
            infoText.text = message;
            textbox.SetActive(true);
            isOn = true;
        }
        


    }
}
