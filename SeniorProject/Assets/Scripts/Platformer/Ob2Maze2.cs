using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ob2Maze2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Ob Hit");

            collision.transform.position = new Vector3(-15.1540003f, -1.27999997f, -0.299999952f);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
