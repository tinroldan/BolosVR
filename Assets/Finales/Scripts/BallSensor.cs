using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSensor : MonoBehaviour
{
    [SerializeField]GameManager manager;
    [SerializeField]int pista;

    private void OnTriggerEnter(Collider other) {
        if(other.CompareTag("Bola"))
        {
            manager.CheckBola(other.gameObject,pista-1);
        }

    }
}
