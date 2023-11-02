using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashCan : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        GetComponent<TriggerZone>().OnEnterEvent.AddListener(InsiderTrash);
    }

    // Update is called once per frame
    public void InsiderTrash(GameObject go)
    {
        go.SetActive(false);
    }
}
