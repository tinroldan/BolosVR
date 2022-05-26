using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] Transform ballSpawn;
    
    public void CheckBola(GameObject ball)
    {
        StartCoroutine(devolverBola(ball));
    }

    IEnumerator devolverBola(GameObject ball)
    {
        yield return new WaitForSeconds(3f);
        ball.transform.position=ballSpawn.transform.position;

    }

}
