using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CoffeeColider : MonoBehaviour
{
    public GameObject buttonCoffee;
    private Renderer buttonColor;
    void Start()
    {
        buttonColor = buttonCoffee.GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // void OnCollisionEnter(Collision collision)
    // {
    //     if (collision.gameObject.tag == "Coffee")
    //     {
    //         // Renderer rend = collision.gameObject.getComponent<Renderer>();
    //         // rend.material.color = Color.red;
    //         Debug.Log("Coffee detected");
    //         // Destroy(collision.gameObject);
    //     }
    // }


    void OnTriggerEnter(Collider other)
{
    if (other.gameObject.tag == "Coffee")
    {
        print("ENTER Colision");
        // Destroy(other.gameObject);
    }
}

    void OnTriggerExit(Collider other)
{
    if (other.gameObject.tag == "Coffee")
    {
        print("EXIT Colision");
        buttonColor.material.color = Color.red;
        // Destroy(other.gameObject);
    }
}

}