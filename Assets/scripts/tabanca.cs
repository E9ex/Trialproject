using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tabanca : MonoBehaviour
{ 
    
    public Transform atesN;

    public GameObject mermii;
    public GameObject mermiiz;
    private void Awake()
    {
        
    }

    
    private void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(mermii, atesN.position, atesN.rotation);
            Instantiate(mermiiz, atesN.position, Quaternion.LookRotation(atesN.forward));
        }
       
    }
}
