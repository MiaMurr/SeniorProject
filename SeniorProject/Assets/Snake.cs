using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snake : MonoBehaviour
{

    private Vector3 _direction = Vector3.right;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            _direction = Vector3.up;
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            _direction = Vector3.down;
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            _direction = Vector3.left;
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            _direction = Vector3.right;
        }

    }

    private void FixedUpdate()
    {
        this.transform.position = new Vector3(
        Mathf.Round(this.transform.position.x) + _direction.x,
        Mathf.Round(this.transform.position.y) + _direction.y,
        Mathf.Round(this.transform.position.z) + _direction.z);
    }
}
    
