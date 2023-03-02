using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class newSnake : MonoBehaviour
{
    private Vector3 _direction;
    [SerializeField] private float snakeSpeed = 0.5f;
    private List<Transform> _segments = new List<Transform>();
    public int initialSize = 4;
    // Start is called before the first frame update

    public void OnMovement(InputValue input) // in the input menu the function is created with all properties 
                                            //relating to buttion behavoiour
    {
        _direction = input.Get<Vector3>(); // WASD is connected to a certian direction of vector 3
    }
    void Start()
    {
        Application.targetFrameRate = 30;
    }

    // Update is called once per frame
    void Update()
    {
        moveplayer();
        
    }

    void moveplayer()
    {
        Vector3 playerMovement = new Vector3(_direction.x, _direction.y, _direction.z);
        //transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(_direction), 0.20f);
        transform.Translate(playerMovement * snakeSpeed * Time.deltaTime, Space.World);
        
        if (_direction.magnitude == 0)
        { 
            return; 
        }
        var rotation = Quaternion.LookRotation(_direction);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, rotation, snakeSpeed);
    }
    private void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Food")
        {
            Grow();

        }
        else if (other.tag == "Obstacle")
        {
            //ResetState();
        }
    }

    void Grow()
    {

    }

    //void ResetState()
    //{
    //    for (int i = 1; i < _segments.Count; i++)
    //    {
    //        Destroy(_segments[i].gameObject);
    //    }

    //    _segments.Clear();
    //    _segments.Add(this.transform);

    //    for (int i = 1; i < this.initialSize; i++)
    //    {
    //        //_segments.Add(Instantiate(this.segmentPrefab));
    //    }

    //    this.transform.position = Vector3.zero;
    //}
}
