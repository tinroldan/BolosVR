using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class axistest : MonoBehaviour
{
    public float axist;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        axist = Input.GetAxis("Tilia.Input.UnityInputManager_Axis9"); ;
    }
}
