using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class InteractObject : MonoBehaviour {

    float range = 1.5f;
    float distance;

    public AudioSource sound;
    public string message;
    public Text infoText;
    public GameObject textbox;

    bool isActivated;

    GameObject player;

    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        distance = Vector3.Distance(this.transform.position, player.transform.position);

        if ((distance <= range))
        {
            if (Input.GetButtonDown("Interact"))
            {
                Interact();
            }

        } 
    }

    public virtual void Interact()
    {
        Debug.Log("Interacting with " + transform.name);
        sound.Play();
        
}

}
