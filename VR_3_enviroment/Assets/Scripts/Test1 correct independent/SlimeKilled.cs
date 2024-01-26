using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;

public class SlimeKilled : MonoBehaviour

{
    public GameObject slime;
	public bool isDeath = false;
	public GameObject vacuum;
	
	


    // Update is called once per frame
    void Update()
    {
        
    }

    public void Break()         // here means death funtion
    {
        Debug.Log("Pistol touch Slime! ");
        isDeath = true;
        slime.GetComponent<Animator>().Play("DeathState");
		vacuum = GameObject.FindWithTag("Vacuum");
		Renderer rend = vacuum.GetComponent<Renderer>();
		rend.material.color = Color.black;
		vacuum.GetComponent<VacuumColider_test>().VacuumCleaning(this.gameObject);
    }
}


