using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMovement : MonoBehaviour {

    private Animator anim;
    public Vector3 startPosition;
    public Vector2 speed = new Vector2(1, 0);

    void Start()
    {
        startPosition = transform.position;
        anim = GetComponent<Animator>();
    }


    void Update () {

        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");

        anim.SetFloat("Horizontal", inputX);
        anim.SetFloat("Vertical", inputY);

        Vector3 movement = new Vector3(
            speed.x * inputX, 
            speed.y * inputY, 
            0);

        movement *= Time.deltaTime;

        transform.Translate(movement);
        

        /*anim.SetFloat("Horizontal", movement.x);
        anim.SetFloat("Vertical", movement.y);
        anim.SetFloat("Magnitude", movement.magnitude);

        transform.position = transform.position + movement *5 * Time.deltaTime;*/
    }

    void FixedUpdate()
    {

        float lastInputX = Input.GetAxis("Horizontal");
        float lastInputY = Input.GetAxis("Vertical");

        if(lastInputX != 0 || lastInputY != 0)
        {
            
            anim.SetBool("Walking", true);
            if(lastInputX > 0)
            {
                anim.SetFloat("LastMoveX", 1f);
            } else if(lastInputX < 0){
                anim.SetFloat("LastMoveX", -1f);
            }else{
                anim.SetFloat("LastMoveX", 0f);
            }

            if (lastInputY > 0)
            {
                anim.SetFloat("LastMoveY", 1f);
            }
            else if (lastInputY < 0)
            {
                anim.SetFloat("LastMoveY", -1f);
            }
            else
            {
                anim.SetFloat("LastMoveY", 0f);
            }
        } else{
            anim.SetBool("Walking", false);
        }

        


    }
}
