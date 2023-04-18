using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlatformerMovement : MonoBehaviour
{
    public Rigidbody player;
    //public GameObject Player;
    [SerializeField]private float speed;
    private Vector3 playerMove;
    [SerializeField] private float snakeTurn;
    public float key = 1;
    [SerializeField] private float wait = 5f;
    bool Delay = true;

    public void OnMovement(InputValue input) // in the input menu the function is created with all properties 
                                             //relating to buttion behavoiour
    {
        playerMove = input.Get<Vector3>(); // WASD is connected to a certian direction of vector 3
    }

    void Start() {
    }

    void Update()
    {
        //Debug.Log(Delay);
        moveplayer();



        if ((Input.GetKeyDown("left shift") || Input.GetKeyDown("right shift")) && Delay)
        {
            sprint();

            Delay = false;

            Invoke("Timer", wait);
        }

        else if (Input.GetKeyUp("left shift") || Input.GetKeyUp("right shift"))
        {
            speed = speed - 3f;
        }
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Key")
        {
            KeyCollection.score += key;
            other.gameObject.SetActive(false);
        }

    }

    void Timer()
    {

        Delay = true;

    }

    void sprint() {

        speed = speed + 3f;

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
