using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.WSA;

public class PongBall : MonoBehaviour
{
    public float PongBallLaunchSpeed;
    public float PongBallBoost;
    public float PongMaxBoostSpeed;
    public Rigidbody rb;
    public int PongSpeedHitCount = 0;
    public PongGameController Controller;


    public IEnumerator PongBallStart()
    {
        resetBall();
        PongSpeedHitCount = 0;
        yield return new WaitForSeconds(1);
        //yield return new WaitForSeconds(0);
        float x = Random.Range(0, 2) == 0 ? -1 : 1;
        float y = Random.Range(0, 2) == 0 ? -1 : 1;
        // AI Testing
        //float x = Random.Range(0, 2) == 0 ? 1 : 1;
        //float y = Random.Range(0, 2) == 0 ? -1 : 1;

        BallSpeed(new Vector3(PongBallLaunchSpeed * x, PongBallLaunchSpeed * y, 0));

    }

    public void BallSpeed(Vector3 direction)
    {
        direction.Normalize();

        float ballSpeed = PongBallLaunchSpeed + PongSpeedHitCount * PongBallBoost;

        rb.velocity = direction * ballSpeed;
    }

    public void PongHitCounter()
    {
        if(PongSpeedHitCount * PongBallBoost < PongMaxBoostSpeed) 
        {
            PongSpeedHitCount++;
        }
    }

    private void resetBall()
    {
        rb.velocity = Vector3.zero;
        transform.position = Vector3.zero;
    }

    public void startPongMatch()
    {
        StartCoroutine(PongBallStart());
    }


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        if (Controller.playerDifficultySlider.slider.value == 0)// easy
        {
            PongMaxBoostSpeed = PongMaxBoostSpeed - 5;
        }
        else if (Controller.playerDifficultySlider.slider.value == 1)// medium
        {

        }
        else // hard
        {
            PongMaxBoostSpeed = PongMaxBoostSpeed + 2.5f;
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
}
