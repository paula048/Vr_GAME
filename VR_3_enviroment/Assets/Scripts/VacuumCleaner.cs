using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;

public class VacuumCleaner : MonoBehaviour
{
    public GameObject vacuum;
    public GameObject slime;


    private NavMeshAgent agent;
    private Transform player;


    private Animator slimeAnimator;
    private Renderer rend;
    bool isDeath = false;


    void Start()
    {
        agent = vacuum.GetComponent<NavMeshAgent>();
        player = slime.transform;


        slimeAnimator = slime.GetComponent<Animator>();
        rend = vacuum.GetComponent<Renderer>();
    }



    void Update()
    {
        
        

        if (slimeAnimator.GetCurrentAnimatorStateInfo(0).IsName("DeathState"))
        {
            rend.material.color = Color.blue;
            StartCoroutine(CheckAnimatorState());
        }
        else
        {
            rend.material.color = Color.red;
        }
    }


    void GoClean()
    {
        agent.SetDestination(player.transform.position);                // move transform agent
        vacuum.GetComponent<NavMeshAgent>().velocity = Vector3.zero;
    }

    


IEnumerator CheckAnimatorState()
{
    // Wait for the next frame
    yield return null;


    agent.SetDestination(player.transform.position);                // move transform agent

    Animator slimeAnimator = slime.GetComponent<Animator>();
    Renderer rend = vacuum.GetComponent<Renderer>();

        rend.material.color = Color.blue;
        vacuum.GetComponent<NavMeshAgent>().velocity = Vector3.zero;
        //Destroy(slime);

}











    // void OnCollisionEnter(Collision collision)
    // {
    //     if (collision.gameObject.tag == "slime")
    //     {
    //         Debug.Log("Collision with slime detected!");
    //         Destroy(collision.gameObject);
    //     }
    // }



    // void OnControllerColliderHit(ControllerColliderHit col){
    //         if (col.gameObject.tag == "slime"){
    //             Destroy(col.gameObject);
    //         }
    //     }



}