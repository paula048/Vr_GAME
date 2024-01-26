using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;

public class VacuumColider_test2 : MonoBehaviour
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
	Debug.Log("Calling vacuum Lista: "+"[ "+ slimeObjects.Count + " ]     "+ slimeObjects);
		AddSlime(slime);
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
    if (!slimeObjects.Contains(slime))
    {
        slimeObjects.Add(slime);
        if (slimeObjects.Count == 1)
        {
            SetSlime(slime);
        }
    }
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
			if (slimeObjects.Count > 0)
			{
				slimeObjects.RemoveAt(0);
			}

            Destroy(collision.gameObject);
			slime=null;
            rend.material.color = Color.cyan;
			
			// jesli lista nie jest pusta, ustaw nastepnego Slima
			if(slimeObjects.Count != 0){
				
				SetSlime(slimeObjects[0]);
				testEnumerate();
				
			}
			
        }
    }




}

