using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class EnemyScript : MonoBehaviour
{
    public Transform player;
    public NavMeshAgent agent;

    // Start is called before the first frame update
    void Start()
    {
        agent.SetDestination( player.position);
//
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination( player.position);
    }
}
