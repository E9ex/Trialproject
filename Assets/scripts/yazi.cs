using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class yazi : MonoBehaviour
{
    public float toplampuan;
    public Text puanyazisi;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Puanekle(float puan)
    {
        toplampuan +=puan;
        puanyazisi.text="puan = "+ toplampuan;

    }
}
