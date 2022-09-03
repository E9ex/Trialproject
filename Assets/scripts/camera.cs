using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public GameObject adam;
    public  Vector3 mesaf;
    void Start()
    {
        mesaf = transform.position - adam.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = adam.transform.position+mesaf;
    }
}
