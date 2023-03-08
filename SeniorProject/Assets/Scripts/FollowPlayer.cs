using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FollowPlayer : MonoBehaviour
{
    public Transform follow;
    NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        follow = gameObject.transform.Find("tracker");
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(follow.position);
    }
}
