using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bow : MonoBehaviour
{ 
    
    public Transform spawnPoint;

   
    public GameObject arrowPrefab;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            Instantiate(arrowPrefab, spawnPoint.position, Quaternion.LookRotation(spawnPoint.forward));
    }
}
