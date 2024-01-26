using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;

public class VacuumColider_test : MonoBehaviour
{
	
	public GameObject vacuum;
	public GameObject slime;
    



    private NavMeshAgent agent;
    private Transform player;



    void Start()
    {
        agent = vacuum.GetComponent<NavMeshAgent>();
        player = slime.transform;
    }
	
	
	public void VacuumCleaning(GameObject slime)
    {
        Debug.Log("Calling vacuum");
		SetSlime(slime);
		testEnumerate();
		

        //StartCoroutine(CheckAnimatorState());
    }
	
	
	void testEnumerate()
    {
		if (slime != null){
			player = this.slime.transform;
			agent.SetDestination(player.transform.position);                // move transform agent

			Animator slimeAnimator = slime.GetComponent<Animator>();
			Renderer rend = vacuum.GetComponent<Renderer>();

			rend.material.color = Color.red;
			vacuum.GetComponent<NavMeshAgent>().velocity = Vector3.zero;
		}


        

    }




	
	
	
	private List<GameObject> slimeObjects = new List<GameObject>();


    public void AddSlime(GameObject slime)
    {
        slimeObjects.Add(slime);
    }
	
	public void SetSlime(GameObject slime)
    {
        this.slime = slime;
    }

	
	
	
	
	



    // Update is called once per frame
    void Update()
    {

    }



    void OnCollisionEnter(Collision collision)
    {
        Renderer rend = vacuum.GetComponent<Renderer>();
        rend.material.color = Color.blue;



        if (collision.gameObject.tag == "slime")
        {
            Debug.Log("Collision with slime detected!");
            Destroy(collision.gameObject);
            rend.material.color = Color.cyan;
			slime=null;
        }
    }




}
