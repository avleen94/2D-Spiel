using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacter : MonoBehaviour {

    [Header("Audio")]
    public AudioClip collideSound;
    public float collideSoundVolumeScale = 1;

    [Header("Other")]
    public Camera cam;
    public bool hasFirstKey;
    public bool hasLastKey;


    protected Rigidbody2D rb;

    public void PlaySingleSound(AudioClip audioClip, float volumeScale = 1)
    {
        if (!audioClip)
            return;

        AudioSource audioSource = gameObject.GetComponent<AudioSource>();

        if (!audioSource)
            audioSource = gameObject.AddComponent(typeof(AudioSource)) as AudioSource;

        audioSource.PlayOneShot(audioClip, volumeScale);
    }

    void Start () {

        rb = GetComponent<Rigidbody2D>();

        cam = Camera.main;
        CameraController camCtrl = cam.GetComponent<CameraController>();
        if (!camCtrl)
            camCtrl = cam.gameObject.AddComponent(typeof(CameraController)) as CameraController;
        if (!camCtrl.target)
        {
            camCtrl.target = transform;
        }

    }
	
	void Update () {
		
	}
}
