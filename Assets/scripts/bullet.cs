using System;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public Rigidbody rb;
    public float bulletforce;
  //  public GameObject mermiizz;

    void Start()
    {
        rb.AddForce(transform.forward*bulletforce,ForceMode.Impulse);
        // = transform.TransformDirection(Vector3.forward * bulletspeed);
        // Update is called once per frame
    }


    public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("hedef"));
        {
            Debug.Log("Collided!" + other.gameObject.name);
            rb.isKinematic = true;
            rb.useGravity = false;
            rb.constraints = RigidbodyConstraints.FreezePosition;
        }
    }
    
}


