using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlatformerMovement : MonoBehaviour
{
    public GameObject Player;
    public float speed;
    private Vector3 _direction;
    public void OnMovement(InputValue input) // in the input menu the function is created with all properties 
                                             //relating to buttion behavoiour
    {
        _direction = input.Get<Vector3>(); // WASD is connected to a certian direction of vector 3
    }
    void moveplayer()
    {   // If makes it that once rotation is done it will stay in that direction
        if (_direction.magnitude == 0)
        {
            return;
        }
        var rotation = Quaternion.LookRotation(_direction);
        //transform.rotation = Quaternion.RotateTowards(transform.rotation, rotation, snakeTurn);
    }
}
