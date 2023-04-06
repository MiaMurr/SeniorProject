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
    public GameObject howtoplayScreenSP;
    public GameObject howtoplayScreenMP;
    public GameObject startmenuButton;

    public void startPreMatch()
    {
        //pongGame.SetActive(true);
        //pongBall.startPongMatch();
        if (twoPlayerToggle.toggle.isOn)
        {
            howtoplayScreenMP.SetActive(true);
        }
        else
        {
            howtoplayScreenSP.SetActive(true);
        }
        startScreen.SetActive(false);
        //scores.SetActive(true);
        //playerCooldownSliders.SetActive(true);
    }
    public void startMatch()
    {
        pongGame.SetActive(true);
        pongBall.startPongMatch();
        if (twoPlayerToggle.toggle.isOn)
        {
            howtoplayScreenMP.SetActive(false);
        }
        else
        {
            howtoplayScreenSP.SetActive(false);
        }
        scores.SetActive(true);
        playerCooldownSliders.SetActive(true);
        startmenuButton.SetActive(true);
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
