using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;






public class MakeCoffee : MonoBehaviour
{
    public GameObject coffeeMaker;
    //public Button yourButton;
    public Rigidbody coffeeCup;
    public GameObject coffeeMakerDoor;
    public bool doCoffe = false;
    



    void Start()
    {

      //  Button btn = yourButton.GetComponent<Button>();
      //  btn.onClick.AddListener(TaskOnClick);
        //if (doCoffe == true)
        //{
            TaskOnClick();
        //}
    }



    void TaskOnClick()
    {
        Debug.Log("Button 'make Coffee' is clicked");
        Vector3 newPosition = new Vector3(1.15980005f,0.518700004f,-0.366100013f);
        Rigidbody newCoconut = Instantiate(coffeeCup, newPosition, transform.rotation) as Rigidbody;
		newCoconut.transform.Rotate(90, 0, 0);
        newCoconut.name = "cup of Coffee";
        coffeeMakerDoor.GetComponent<MoveMaker>().TaskOnClick();
    }





    void Update()
    {



    }
}
