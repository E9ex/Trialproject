using System;
using UnityEngine;

public class bullet : MonoBehaviour
{
   public yazi yazimiz;
   
    private void Awake()
    {
        yazimiz = FindObjectOfType<yazi>();
    }

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
        
        if (other.gameObject.CompareTag("mavi"))
        {
            Debug.Log("Collided!" + other.gameObject.name);
            rb.isKinematic = true;
            rb.useGravity = false;
            rb.constraints = RigidbodyConstraints.FreezePosition;
            
        }
        if (other.gameObject.CompareTag("kirmizi"))
        {
            Debug.Log("Collided!" + other.gameObject.name);
            rb.isKinematic = true;
            rb.useGravity = false;
            rb.constraints = RigidbodyConstraints.FreezePosition;
         
        }
        if (other.gameObject.CompareTag("siyah"))
        {
            Debug.Log("Collided!" + other.gameObject.name);
            rb.isKinematic = true;
            rb.useGravity = false;
            rb.constraints = RigidbodyConstraints.FreezePosition;
            
        }
        if (other.gameObject.CompareTag("sari"))
        {
            Debug.Log("Collided!" + other.gameObject.name);
            rb.isKinematic = true;
            rb.useGravity = false;
            rb.constraints = RigidbodyConstraints.FreezePosition;
           
        }

        if (other.gameObject.CompareTag("kirmizi"))
            yazimiz.Addpoint(10);
        if (other.gameObject.CompareTag("sari"))
                yazimiz.Addpoint(20);
            if (other.gameObject.CompareTag("sari"))
                yazimiz.Addpoint(15);
            if (other.gameObject.CompareTag("mavi"))
                yazimiz.Addpoint(5);
          
    }

    

}


