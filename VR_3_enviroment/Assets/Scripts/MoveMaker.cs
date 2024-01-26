using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;

public class MoveMaker : MonoBehaviour
{
    //public Button yourButton;
    public GameObject buttonOfMaker;
    public float speed = 0.5f;
    public Vector3 targetPosition;

    public bool isChange = true;

    private Renderer rend;

    void Start()
    {
        //Button btn = yourButton.GetComponent<Button>();
        //btn.onClick.AddListener(TaskOnClick);


        rend = buttonOfMaker.GetComponent<Renderer>();
    }

    public void TaskOnClick()
    {
        targetPosition = transform.position + new Vector3(0, 0.2f, 0);
        rend.material.color = Color.red;
    
        
        if (isChange)
        {
            StartCoroutine(ChangeColor());
        }

        StartCoroutine(DelayedMoveToTarget());

    }




    IEnumerator DelayedMoveToTarget()
{
    yield return new WaitForSeconds(4.5f);
    StartCoroutine(MoveToTarget());
}





    
Color newColor = new Color32(255, 108, 0, 255);


IEnumerator ChangeColor()
{
    float elapsedTime = 0f;

    while (isChange && elapsedTime<5f)
    {
        rend.material.color = newColor;
        yield return new WaitForSeconds(0.5f);
        elapsedTime+=0.5f;
   
        rend.material.color = Color.black;
        yield return new WaitForSeconds(0.5f);
        elapsedTime+=0.5f;   
    }
    rend.material.color = Color.green;
}



    IEnumerator MoveToTarget()
    {
        while (Vector3.Distance(transform.position, targetPosition) > 0.01f)
        {
            
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
            yield return null;
        }
    }
}
