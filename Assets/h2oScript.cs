using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class h2oScript : MonoBehaviour
{
    public GameObject hydogen1;
    public GameObject oxygen;
    public GameObject hydrogen2;
    public Animation clip1;
    public GameObject empty;
    public bool changed1 = false;
    public bool changed2 = false;

    public GameObject water;
    public GameObject oh;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance( hydogen1.transform.position , oxygen.transform.position) < 0.5f)
        {
            changed1 = true;
            
            hydogen1.transform.SetParent(empty.transform);
            oxygen.transform.SetParent(empty.transform);
        }

        if (changed1)
        {
            hydogen1.transform.position = new Vector3((float)(oxygen.transform.position.x + 0.2),(float)( oxygen.transform.position.y - 0.2), oxygen.transform.position.z);
            oh.SetActive(true);

        }


        if (Vector3.Distance(hydrogen2.transform.position, oxygen.transform.position) < 0.5f)
        {
            changed2 = true;

            hydogen1.transform.SetParent(empty.transform);
            oxygen.transform.SetParent(empty.transform);
        }

        if (changed2)
        {
            hydrogen2.transform.position = new Vector3((float)(oxygen.transform.position.x - 0.2), (float)(oxygen.transform.position.y - 0.2), oxygen.transform.position.z);
            oh.SetActive(true);

        }

        if(changed1 && changed2)
        {
            water.SetActive(true);
            oh.SetActive(false);
        }
    }


    public GameObject planeFinder;

    public void contentChanged()
    {
        planeFinder.SetActive(false);
    }
}
