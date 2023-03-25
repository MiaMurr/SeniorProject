using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PongScoreManager : MonoBehaviour
{
    private int leftScore = 0;
    private int rightScore = 0;
    public PongMatchSlider matchSlider;
    public GameObject gameOverScreen;
    public PongGameController gameController;
    public int endgameScore;
    public PongBall pongBall;

    public TextMeshProUGUI leftPlayerScore;
    public TextMeshProUGUI rightPlayerScore;

    public void leftPlayerScored()
    {
        leftScore++;
        leftPlayerScore.text = leftScore.ToString();
        Debug.Log(leftScore.ToString());
        scoreCheck();
    }
    public void rightPlayerScored()
    {
        rightScore++;
        rightPlayerScore.text = rightScore.ToString();
        Debug.Log(rightScore.ToString());
        scoreCheck();
    }
    public void scoreCheck()
    {
        if(leftScore == endgameScore || rightScore == endgameScore)
        {
            gameController.pongGame.SetActive(false);
            gameController.playerCooldownSliders.SetActive(false);
            gameOverScreen.SetActive(true);
            if (leftScore == endgameScore) 
            { 
                gameController.leftWinner.SetActive(true);
            }
            if (rightScore == endgameScore)
            {
                gameController.rightWinner.SetActive(true);
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        endgameScore = ((int)matchSlider.slider.value);
    }

    // Update is called once per frame
    void Update()
    {
    }
}
