using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SlimeMove : MonoBehaviour
{
    private Transform player;
    private NavMeshAgent agent;
    public float enemyDistance = 0.02f;
    void Start()
    {
        player = GameObject.FindWithTag("Player").transform;
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(player);
        agent.SetDestination(player.transform.position);

        //if (Vector3.Distance(transform.position, player.position) < enemyDistance)




        KillSlime killSlimeComponent = gameObject.GetComponent<KillSlime>();
        if (killSlimeComponent != null && killSlimeComponent.isDeath)
        {
            gameObject.GetComponent<NavMeshAgent>().velocity = Vector3.zero;
        }



    }
}