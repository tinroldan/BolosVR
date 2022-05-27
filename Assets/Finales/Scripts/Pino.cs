using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pino : MonoBehaviour
{
    Vector3 startPosition;
    Vector3 startRotation;

    public bool isUP;


    void Start()
    {
        startPosition = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        startRotation = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, transform.eulerAngles.z);
    }

    void Update()
    {
        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.forward, out hit, 1f))
        {
            if (hit.transform.tag == "Pista")
            {
                isUP = true;
            }
            else
            {
                isUP = false;

            }
        }
        else
        {
            isUP = false;
        }

        if (isUP)
        {
            Debug.DrawRay(transform.position, transform.forward * 1f, Color.green);

        }
        else
        {
            Debug.DrawRay(transform.position, transform.forward * 1f, Color.red);
        }


    }

    //bool CheckRay()
    //{


    //}

    public void ReturnPos()
    {
        transform.position = startPosition;
        transform.eulerAngles = startRotation;
    }


}
