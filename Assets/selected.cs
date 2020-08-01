using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class selected : MonoBehaviour
{
    
    public bool Selected;
    private RaycastHit hit;

    public static GameObject selectedObject;
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
        if (Physics.Raycast(ray, out hit) && hit.transform.gameObject == this.gameObject)
        {
            selectedObject = this.gameObject;
        }
           


    }
}

