using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Movement2 : MonoBehaviour
{
    public Rigidbody player;
    //public GameObject Player;
    [SerializeField] private float speed;
    private Vector3 playerMove;
    [SerializeField] private float snakeTurn;
    public float key = 1;
    public float force = 10;

    public float Jump = 8;

    //public void AddForce(Vector3 force, ForceMode mode = ForceMode.Force;

    public void OnJump() {

        //player.AddForce();
        player.AddForce(0, Jump, 0, ForceMode.Impulse);
        //player.AddForce(Physics.gravity * (gravityW - 1) * player.mass);
        //Debug.Log("W");

    }

    public void OnMovement(InputValue input) // in the input menu the function is created with all properties 
                                             //relating to buttion behavoiour
    {
        playerMove = input.Get<Vector3>(); // WASD is connected to a certian direction of vector 3
    }

    void Update()
    {
        moveplayer();
        //OnJump();
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Key")
        {
            KeyCollection.score += key;
            other.gameObject.SetActive(false);
        }

    }

    void moveplayer()
    {

        // If makes it that once rotation is done it will stay in that direction
        if (playerMove.magnitude == 0)
        {
            return;
        }
        
            var rotation = Quaternion.LookRotation(playerMove);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, rotation, snakeTurn);
        
        transform.Translate(playerMove * speed * Time.deltaTime, Space.World);
        //player.MovePosition(transform.position + playerMove * Time.deltaTime * speed);
    }
}
