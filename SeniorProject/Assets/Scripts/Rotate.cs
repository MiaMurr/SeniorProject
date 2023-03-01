using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public Transform target;
    public float speed = 10.0f;

    void Update()
    {
        transform.RotateAround(
            target.transform.position,
            target.transform.up,
            speed * Time.deltaTime);

    }
}
