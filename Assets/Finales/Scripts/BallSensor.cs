using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSensor : MonoBehaviour
{
    [SerializeField]GameManager manager;

    private void OnTriggerEnter(Collider other) {
        if(other.CompareTag("Bola"))
        {
            manager.CheckBola(other.gameObject);
        }

    }
}
