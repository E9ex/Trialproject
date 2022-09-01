using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public Rigidbody rb;
    public float bulletforce;
    public GameObject mermiiz;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(transform.forward*bulletforce,ForceMode.Impulse);
        // = transform.TransformDirection(Vector3.forward * bulletspeed);
        // Update is called once per frame
    }

    void Update()
    {
        
    }
    public void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "target")


        {
            rb.isKinematic = true;
            rb.velocity=Vector3.zero;
        }
    }
}
