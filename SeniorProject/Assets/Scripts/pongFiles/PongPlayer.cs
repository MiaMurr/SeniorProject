using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
//using UnityEditorInternal;
using UnityEngine;
//using static UnityEditor.Experimental.GraphView.GraphView;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;
using Newtonsoft.Json.Linq;

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

    public PongProjectile projectilePrefab;
    public Transform projectileLoc;
    public float projectileCooldown;
    public float player1Cooldown;
    public float player2Cooldown;
    public PongScoreManager scoreManager;
    public AudioSource playScoreBounceSound;
    public PongBall pongBall;
    public PongPlayerController players;
    public GameObject LeftPlayerCooldownSlider;
    public AudioSource soundEffect;



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

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "PongRightPlayerProjectile")
        {
            playScoreBounceSound.Play();
            scoreManager.rightPlayerScored();
            if (scoreManager.gameOverScreen.activeSelf == false)
            {
                StartCoroutine(pongBall.PongBallStart());
                players.resetPlayer();
            }
        }
        if (collision.gameObject.tag == "PongLeftPlayerProjectile")
        {
            playScoreBounceSound.Play();
            scoreManager.leftPlayerScored();
            if (scoreManager.gameOverScreen.activeSelf == false)
            {
                StartCoroutine(pongBall.PongBallStart());
                players.resetPlayer();
            }
        }
    }

    public void PlayerOneMovement(InputAction.CallbackContext context)
    {
        if (context.control != null)
        {
            motion = context.ReadValue<Vector3>().y;
        }
        else
        {
            motion = 0;
        }
    }
    public void PlayerTwoMovement(InputAction.CallbackContext context)
    {
        if (gameController.twoPlayerToggle.toggle.isOn)
        {
            if (context.control != null)
            {
                motion = context.ReadValue<Vector3>().y;
            }
            else
            {
                motion = 0;
            }
        }
    }

    public void PlayerOneFire(InputAction.CallbackContext context)
    {
        if (player1Cooldown <= 0 && isAI == false)
        {
            var newProjectile1 = Instantiate(projectilePrefab, projectileLoc.position, projectileLoc.rotation);
            newProjectile1.tag = "PongLeftPlayerProjectile";
            newProjectile1.transform.parent = gameObject.transform.parent;
            player1Cooldown = projectileCooldown;
            soundEffect.Play();
        }
    }
    public void PlayerTwoFire(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            if (gameController.twoPlayerToggle.toggle.isOn)
            {
                if (player2Cooldown <= 0)
                {
                    var newProjectile2 = Instantiate(projectilePrefab, projectileLoc.position, projectileLoc.rotation);
                    newProjectile2.tag = "PongRightPlayerProjectile";
                    newProjectile2.transform.parent = gameObject.transform.parent;
                    player2Cooldown = projectileCooldown;
                    soundEffect.Play();
                }
            }
        }
        
    }




    // Start is called before the first frame update
    void Start()
    {
        rb= GetComponent<Rigidbody>();
        player1Cooldown = projectileCooldown;
        player2Cooldown = projectileCooldown;
        if (gameController.twoPlayerToggle.toggle.isOn == false)
        {
            isAI = true;
            LeftPlayerCooldownSlider.SetActive(false);
        }
        if (gameController.playerDifficultySlider.slider.value == 0) //easy
        {
            projectileCooldown = projectileCooldown + 5;
            projectilePrefab.speed = 5.5f;
        }
        else if (gameController.playerDifficultySlider.slider.value == 1) //medium
        {
            PongSpeed = PongSpeed + 1.0f;
            projectilePrefab.speed = 10f;
        }
        else //hard
        {
            projectileCooldown = projectileCooldown - 2.5f;
            PongSpeed = PongSpeed + 2.0f;
            projectilePrefab.speed = 15f;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (player1Cooldown > 0)
        {
            player1Cooldown -= Time.deltaTime;
        }
        if (player2Cooldown > 0)
        {
            player2Cooldown -= Time.deltaTime;
        }




        //if (PongPlayerOne)
        //{
        //    motion = Input.GetAxisRaw("PongPlayer1Movement");
        //    if (Input.GetButtonDown("PongPlayer1Fire"))
        //    {
        //        if (player1Cooldown <= 0 && isAI == false)
        //        {
        //            var newProjectile1 = Instantiate(projectilePrefab, projectileLoc.position, projectileLoc.rotation);
        //            newProjectile1.tag = "PongLeftPlayerProjectile";
        //            newProjectile1.transform.parent = gameObject.transform.parent;
        //            player1Cooldown = projectileCooldown;
        //            soundEffect.Play();
        //        }
        //    }
        //}
        //else if (gameController.twoPlayerToggle.toggle.isOn)
        //{
        //    motion = Input.GetAxisRaw("PongPlayer2Movement");
        //    if (Input.GetButtonDown("PongPlayer2Fire"))
        //    {
        //        if (player2Cooldown <= 0)
        //        {
        //            var newProjectile2 = Instantiate(projectilePrefab, projectileLoc.position, projectileLoc.rotation);
        //            newProjectile2.tag = "PongRightPlayerProjectile";
        //            newProjectile2.transform.parent = gameObject.transform.parent;
        //            player2Cooldown = projectileCooldown;
        //            soundEffect.Play();
        //        }
        //    }
        //}

        if (!gameController.twoPlayerToggle.toggle.isOn && PongPlayerOne == false) // AI
        {
            if (player2Cooldown <= 0)
            {
                var newProjectile2 = Instantiate(projectilePrefab, projectileLoc.position, projectileLoc.rotation);
                newProjectile2.tag = "PongRightPlayerProjectile";
                newProjectile2.transform.parent = gameObject.transform.parent;
                player2Cooldown = projectileCooldown;
                soundEffect.Play();
            }
            if (chaseBall == true)
            {
                if (gameController.pongBall.transform.position.y > transform.position.y + 1)
                {
                    motion = 1.75f;
                    if (gameController.playerDifficultySlider.slider.value == 1) //medium
                    {
                        motion = 2.0f;
                    }
                    if (gameController.playerDifficultySlider.slider.value == 2) //hard
                    {
                        motion = 2.5f;
                    }
                }
                else if (gameController.pongBall.transform.position.y < transform.position.y - 1)
                {
                    motion = -1.75f;
                    if (gameController.playerDifficultySlider.slider.value == 1) //medium
                    {
                        motion = -2.0f;
                    }
                    if (gameController.playerDifficultySlider.slider.value == 2) //hard
                    {
                        motion = -2.5f;
                    }
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
