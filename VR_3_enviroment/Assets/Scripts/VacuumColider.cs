using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VacuumColider : MonoBehaviour
{

    public GameObject vacuum;

    // Start is called before the first frame update
    void Start()
    {

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
        }
    }




}