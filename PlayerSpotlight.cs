using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpotlight : MonoBehaviour
{
    public Transform target;

    void Update()
    {
        if (target != null)
        {
            Vector2 targetPos = target.transform.position;

            transform.position = new Vector3(targetPos.x, targetPos.y, transform.position.z);
        }
    }


}