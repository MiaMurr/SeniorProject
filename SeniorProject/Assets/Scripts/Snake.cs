using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
//using UnityEngine.Windows;

public class Snake : MonoBehaviour
{

    private Vector3 _direction = Vector3.right;

    

    private List<Transform> _segments = new List<Transform>();

    public Transform segmentPrefab;

    public int initialSize = 4;

    private void Start()
    {
        _segments = new List<Transform>();
        _segments.Add(this.transform);
        ResetState();
        Application.targetFrameRate = 30;//make sure that the game does not run at crazy speeds
    }
    
    /*public void OnMovement(InputValue input) // in the input menu the function is created with all properties 
     //relating to buttion behavoiour
    {
        
        _direction = input.Get<Vector3>(); // WASD is connected to a certian direction of vector 3.
    }*/

     private void Update()
     {
        if (Input.GetKeyDown(KeyCode.W))
        {
            _direction = Vector3.up;
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            _direction = Vector3.down;
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            _direction = Vector3.left;
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            _direction = Vector3.right;
        }
        
    }


    private void FixedUpdate()
    {
        for (int i = _segments.Count - 1; i > 0; i--)
        {
            _segments[i].position = _segments[i - 1].position;
        }

        this.transform.position = new Vector3(
        Mathf.Round(this.transform.position.x) + _direction.x,
        Mathf.Round(this.transform.position.y) + _direction.y,
        Mathf.Round(this.transform.position.z) + _direction.z);
    }

    private void Grow()
    {
        Transform segment = Instantiate(this.segmentPrefab);
        segment.position = _segments[_segments.Count - 1].position;

        _segments.Add(segment);
    }  

     private void ResetState()
    {
        for (int i =1; i < _segments.Count; i++)
        {
            Destroy(_segments[i].gameObject);
        }

        _segments.Clear();
        _segments.Add(this.transform);

        for (int i = 1; i < this.initialSize; i++)
        {
            _segments.Add(Instantiate(this.segmentPrefab));
        }

        this.transform.position = Vector3.zero;
    }
     
    private void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Food")
        {
            Grow();

        }
        else if (other.tag == "Obstacle")
        {
            ResetState();
        }



    }

}
