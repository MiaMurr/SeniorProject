using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class OutOfBounds : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Out of bounds");
            collision.transform.position = new Vector3(0.0199999996f, 1f, 0.389999986f);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
