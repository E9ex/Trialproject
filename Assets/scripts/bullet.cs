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
        if (other.gameObject.TryGetComponent(out targetdetect script))
        {
            script.Myname();
        }
        if (other.gameObject.CompareTag("mavi"))
        {
            Debug.Log("Collided!" + other.gameObject.name);
            rb.isKinematic = true;
            rb.useGravity = false;
            rb.constraints = RigidbodyConstraints.FreezePosition;
            yazimiz.Addpoint(5);
        }
        if (other.gameObject.CompareTag("kirmizi"))
        {
            rb.isKinematic = true;
            rb.useGravity = false;
            rb.constraints = RigidbodyConstraints.FreezePosition;
            yazimiz.Addpoint(10);
        }
        if (other.gameObject.CompareTag("siyah"))
        {
            
            rb.isKinematic = true;
            rb.useGravity = false;
            rb.constraints = RigidbodyConstraints.FreezePosition;
            yazimiz.Addpoint(10);
        }
        if (other.gameObject.CompareTag("sari"))
        {
        
            rb.isKinematic = true;
            rb.useGravity = false;
            rb.constraints = RigidbodyConstraints.FreezePosition;
            yazimiz.Addpoint(20);
        }

    
          
    }

    

}


