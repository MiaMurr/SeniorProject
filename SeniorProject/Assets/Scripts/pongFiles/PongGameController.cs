using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PongGameController : MonoBehaviour
{

    public PongBall pongBall;
    public GameObject pongGame;
    public GameObject startScreen;
    public GameObject scores;
    public GameObject leftWinner;
    public GameObject rightWinner;
    public PongTwoPlayerToggle twoPlayerToggle;
    public GameObject playerCooldownSliders;
    public PongDifficultySlider playerDifficultySlider;


    public void startMatch()
    {
        pongGame.SetActive(true);
        pongBall.startPongMatch();
        startScreen.SetActive(false);
        scores.SetActive(true);
        playerCooldownSliders.SetActive(true);
    }

    


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
