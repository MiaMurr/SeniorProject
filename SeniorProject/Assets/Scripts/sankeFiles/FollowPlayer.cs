using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FollowPlayer : MonoBehaviour
{
    public GameObject parent;
    public GameObject child;
    public Transform follow;
    NavMeshAgent agent;
    // Start is called before the first frame update
    public string nameS;
    public int num;
    public newSnake newSnake;
    GameObject test;
    void Start()
    {
        // setting up snake
        test = GameObject.Find("Snake");
        num = PlayerPrefs.GetInt("numOfseg");
        num = num - 1;

        Debug.Log("if called at all?");
        if (num == 0)
        {
            agent = GetComponent<NavMeshAgent>();
            parent = GameObject.Find("Snake");
            child = parent.transform.GetChild(1).gameObject;
            follow = child.transform;
            
        }
        else
        {
            Debug.Log(num);
            Debug.Log(nameS);
            agent = GetComponent<NavMeshAgent>();
            nameS = PlayerPrefs.GetString("SnakeNameS");
            parent = GameObject.Find(nameS);
            child = parent.transform.GetChild(0).gameObject;
            follow = child.transform;
        }

        

    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(follow.position);
        
    }
}
