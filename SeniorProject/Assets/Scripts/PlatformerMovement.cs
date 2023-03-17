using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlatformerMovement : MonoBehaviour
{
    public GameObject Player;
    public float speed;

    void Update() {


        Vector3 dir = Vector3.zero;
        if (Input.GetKey(KeyCode.A))
        {
            dir.x = -1;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            dir.x = 1;
        }

        if (Input.GetKey(KeyCode.W))
        {
            dir.y = 1;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            dir.y = -1;

        }

        dir.Normalize();
        //GetComponent<Rigidbody2D>().velocity = speed * dir;

        //if (Input.GetKeyDown("W")){

        //    GetComponent<Rigidbody>().velocity = new Vector3(0,5, 0);
        
        //}
    
    }
   
}
