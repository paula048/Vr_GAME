using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;

public class KillSlime : MonoBehaviour

{
    public GameObject slime;


    public GameObject vacuum;
    public bool isDeath = false;



    private NavMeshAgent agent;
    private Transform player;



    void Start()
    {
        agent = vacuum.GetComponent<NavMeshAgent>();
        player = slime.transform;



    }


    void TaskOnClick()
    {
        Debug.Log("You have clicked the button!");

        slime.GetComponent<Animator>().Play("DeathState");
        StartCoroutine(CheckAnimatorState());
    }

    IEnumerator CheckAnimatorState()
    {
        // Wait for the next frame
        yield return null;


        agent.SetDestination(player.transform.position);                // move transform agent

        Animator slimeAnimator = slime.GetComponent<Animator>();
        Renderer rend = vacuum.GetComponent<Renderer>();

        if (slimeAnimator.GetCurrentAnimatorStateInfo(0).IsName("DeathState"))
        {
            rend.material.color = Color.red;
            vacuum.GetComponent<NavMeshAgent>().velocity = Vector3.zero;
            //Destroy(slime);
        }
        else
        {
            rend.material.color = Color.black;
        }
    }




    // Update is called once per frame
    void Update()
    {
        
    }

    public void Break()         // here means death funtion
    {
        Debug.Log("Pistol touch Slime! ");
        isDeath = true;
        slime.GetComponent<Animator>().Play("DeathState");
        TaskOnClick();
    }
}
