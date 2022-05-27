using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] Transform ballSpawn;
    [SerializeField] PinosManager[] pistas;
    
    public void CheckBola(GameObject ball,int pista)
    {
        StartCoroutine(devolverBola(ball));
        pistas[pista].AnimRecoger();
    }

    IEnumerator devolverBola(GameObject ball)
    {
        yield return new WaitForSeconds(3f);
        ball.transform.position=ballSpawn.transform.position;

    }

}
