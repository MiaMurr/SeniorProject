using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class PlatformerMovement : MonoBehaviour
{
    public Rigidbody player;
    //public GameObject Player;
    [SerializeField]private float speed;
    private Vector3 playerMove;
    [SerializeField] private float snakeTurn;
    private int Done = 1;
    public float key = 1;
    [SerializeField] private float wait = 5f;
    bool Delay = true;
    public float Push = 50f;

    public GameObject A;
    public GameObject B;
    public float time;

    public void OnMovement(InputValue input) // in the input menu the function is created with all properties 
                                             //relating to buttion behavoiour
    {
       
        playerMove = input.Get<Vector3>(); // WASD is connected to a certian direction of vector 3
    }

    void Start() {
        time = 0;
        A.SetActive(true);
        B.SetActive(false);
    }

    void Update()
    {
        //Debug.Log(Delay);
        moveplayer();

        if (time == 1) {
            B.SetActive(true);
        }

        if (time == 0)
        {
            B.SetActive(false);
        }
        if ((Input.GetKeyUp("left shift") || Input.GetKeyUp("right shift")) && Delay && Done == 1)
        {
            time += 1;
            
            Debug.Log("Sprinting");
            sprint();

            Delay = false;


            Invoke("Timer", wait);
            Invoke("SprintAct", wait);

            
            StartCoroutine(Wait());


        }

    }

    IEnumerator Wait()
    {
        Done = 2;
        Debug.Log("wait");

        yield return new WaitForSeconds(10f);
        
        Debug.Log(time.ToString("00"));
        Debug.Log("Im done waiting");
        time -= 1;
        Done = 1;
        

    }

    void SprintAct() {


        speed = speed - 3f;

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            Debug.Log("I'm hitting a Wall");
            Vector3 dir = collision.contacts[0].point - transform.position;

            dir = -dir.normalized;

            GetComponent<Rigidbody>().AddForce(dir * Push);
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
