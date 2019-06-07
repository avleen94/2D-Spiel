using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : InteractObject {

    public Animator anim;
    public bool isEnabled = false;

    public override void Interact()
    {
        if (!isEnabled)
        {
            anim.SetBool("isActivated", true);
            isEnabled = true;
            sound.Play();

        } else
        {
            anim.SetBool("isActivated", false);
            isEnabled = false;
        }

    }

}
