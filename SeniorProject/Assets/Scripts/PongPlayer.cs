using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEditorInternal;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;
using UnityEngine.SceneManagement;

public class PongPlayer : MonoBehaviour
{
    public bool PongPlayerOne;
    public float PongSpeed;
    public Rigidbody rb;
    private float motion;
    public PongGameController gameController;
    private bool isAI = false;
    public Collider ball;
    private bool chaseBall = false;




    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Ball" && isAI == true)
        {
            chaseBall= true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.name == "Ball" && isAI == true)
        {
            chaseBall = false;
        }
    }



    // Start is called before the first frame update
    void Start()
    {
        rb= GetComponent<Rigidbody>();
        if(gameController.twoPlayerToggle.toggle.isOn == false)
        {
            isAI= true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(PongPlayerOne)
        {
            motion = Input.GetAxisRaw("Player1Movement");
        }
        else if (gameController.twoPlayerToggle.toggle.isOn)
        {
            motion = Input.GetAxisRaw("Player2Movement");
        }
        else
        {
            if(chaseBall==true)
            {
                if (gameController.pongBall.transform.position.y > transform.position.y + 1)
                {
                    motion = 1.75f;
                }
                else if (gameController.pongBall.transform.position.y < transform.position.y - 1)
                {
                    motion = -1.75f;
                }
            }
            else
            {
                if (gameController.pongBall.transform.position.x < 17.5 && gameController.pongBall.transform.position.x > 0 && gameController.pongBall.transform.position.y < 0 && gameController.pongBall.rb.velocity.x > -9)
                {
                    motion = 1;
                }
                else if (gameController.pongBall.transform.position.x < 17.5 && gameController.pongBall.transform.position.x > 0 && gameController.pongBall.transform.position.y > 0 && gameController.pongBall.rb.velocity.x > -9)
                {
                    motion = -1;
                }
                else if (gameController.pongBall.transform.position.y > transform.position.y + 1)
                {
                    motion = 1;
                }
                else if (gameController.pongBall.transform.position.y < transform.position.y - 1)
                {
                    motion = -1;
                }
                else
                {
                    motion = 0;
                }
            }
        }
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector3(rb.velocity.x, motion * PongSpeed, rb.velocity.z);
    }
}
