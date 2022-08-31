using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tabanca : MonoBehaviour
{ 
    
    public Transform atesN;

    public GameObject mermii;
    private void Awake()
    {
        
    }

    
    private void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Space));
        {
            Instantiate(mermii, atesN.position, atesN.rotation);
        }
    }
}
