using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class newSnake : MonoBehaviour
{
    public GameObject SnakePlayer;
    public GameObject GameOver;
    public GameObject HideScore;
    public GameObject HideHome;
    public GameObject HideHighScore;
    public GameObject Life1;
    public GameObject Life2;
    public GameObject Life3;
    public int LossLif = 1;
    private Vector3 _direction;
    [SerializeField] private float snakeSpeed = 0.5f;
    [SerializeField] private float snakeTurn = 20.0f;

    private List<Transform> _segments = new List<Transform>();
    public int numOfSeg = 0;
    public Transform segmentPrefab;
    public int initialSize = 4;
    public string SnakeSegmentName;
    public userLoading userLoading = null;
    

    
    public void OnMovement(InputValue input) // in the input menu the function is created with all properties 
                                            //relating to buttion behavoiour
    {
        _direction = input.Get<Vector3>(); // WASD is connected to a certian direction of vector 3
    }
    void Start()
    {
        // starts Game at 30 frams and sets the segment number
        Application.targetFrameRate = 30;
        PlayerPrefs.SetInt("numOfseg",0);
        
    }

    // Update is called once per frame
    void Update()
    {
        // will make sure the snake is in constint mostion
        SnakePlayer.gameObject.transform.position += transform.forward * Time.deltaTime * snakeSpeed;
        moveplayer();
        
    }

    // will control the rotation of the player
    void moveplayer()
    {   // If makes it that once rotation is done it will stay in that direction
        if (_direction.magnitude == 0)
        { 
            return; 
        }
        var rotation = Quaternion.LookRotation(_direction);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, rotation, snakeTurn);
    }
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.tag == "Food")
        {
            Grow();

        }

        else if (other.tag == "Obstacle")
        {
            switch (SnakeScore.Lives)
            {

                case 3:
                    SnakeScore.Lives -= LossLif;
                    Life1.SetActive(false);
                    break;
                case 2:
                    SnakeScore.Lives -= LossLif;
                    Life2.SetActive(false);
                    break;
                case 1:
                    SnakeScore.Lives -= LossLif;
                    Life3.SetActive(false);
                    break;
                case 0:

                    // Game Over Screen
                    userLoading.WriteString();
                    SnakePlayer.SetActive(false);
                    HideScore.SetActive(false);
                    HideHighScore.SetActive(false);
                    HideHome.SetActive(false);
                    GameOver.SetActive(true);
                    break;
                default:
                    break;
            }
            ResetState();
        }
    }

    void Grow()
    {
        
        Transform segment = Instantiate(this.segmentPrefab);
        _segments.Add(segment);
        SnakeSegmentName = "SnakeSigment" + numOfSeg;
        segment.name = (SnakeSegmentName);
        numOfSeg++;
        int temp = numOfSeg-2;
        SnakeSegmentName = "SnakeSigment" + temp;
        PlayerPrefs.SetString("SnakeNameS", SnakeSegmentName);
        PlayerPrefs.SetInt("numOfseg",numOfSeg);
    }

    void ResetState()
    {
        this.transform.position = new Vector3(0,9,0);
        
    }
}
