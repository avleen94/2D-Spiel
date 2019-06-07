using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target;
    public float followAhead = 5f;
    public float smoothing = 2f;

    public Vector2 preferredY = new Vector2(0, 2.5f);
    public float offsetY = 2f;

    public Vector3 targetPosition;

    private Vector2 worldPosMin = new Vector2(-25f, -25f);
    private Vector2 worldPosMax = new Vector2(40f, 40f);

    void Update()
    {
        if (target != null)
        {
            Vector2 targetPos = target.transform.position;

            float x = Mathf.Clamp(targetPos.x, worldPosMin.x, worldPosMax.x);
            float y = Mathf.Clamp(targetPos.y, worldPosMin.y, worldPosMax.y);

            transform.position = new Vector3(x, y, transform.position.z);
        }
    }

    
}