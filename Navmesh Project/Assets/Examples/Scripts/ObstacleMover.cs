using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMover : MonoBehaviour
{
    public float moveSpeed;
    public float startPosition;

    void Start()
    {
        startPosition = gameObject.transform.localPosition.z;
        moveSpeed = -1f;
    }

    void Update()
    {
        if (gameObject.transform.localPosition.z < startPosition - 3f)
        {
            moveSpeed = 1f;
        }
        if (gameObject.transform.localPosition.z > startPosition)
        {
            moveSpeed = -1f;
        }
        gameObject.transform.localPosition += new Vector3(0f, 0f, moveSpeed * Time.deltaTime); ;
    }
}
