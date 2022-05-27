using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PinosManager : MonoBehaviour
{
    [SerializeField] List<Pino> pinos;
    [SerializeField] Animator anim;
    [SerializeField] TMP_Text panelPuntos;
    public int points;

    private void Start() {
        points = 0;
        panelPuntos.text = points.ToString();
    }

    public void CheckPoints()
    {
        

    }

    public void AnimRecoger()
    {
        anim.SetBool("recoger", true);
    }


    public void RestorePinos()
    {
        print("me llmaron aaaaaaaaaaaaaa");
        points = 0;
        for (int i = 0; i < pinos.Count; i++)
        {
            if (pinos[i].isUP == false)
            {
                ++points;
            }
        }
        panelPuntos.text = points.ToString();
        
        foreach (var item in pinos)
        {
            item.ReturnPos();
        }
        anim.SetBool("recoger", false);

    }

}
