using System;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public Rigidbody rb;
    public float bulletforce;
  //  public GameObject mermiizz;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(transform.forward*bulletforce,ForceMode.Impulse);
        // = transform.TransformDirection(Vector3.forward * bulletspeed);
        // Update is called once per frame
    }

    void Update()
    {
      /*  RaycastHit temas;
        if (Physics.Raycast(transform.position,transform.forward,out temas,3.0f)) //Güzel bir başlangıç burdan yürüyebilirsin. Fakat buraya gerek kalmadan alttaki collider kısmından çözebilirsin.
        {
            Debug.Log("vurdu gol oldusanırım");
        }
        */
    }


    public void OnCollisionEnter(Collision other)
    
    {
        if (other.gameObject.CompareTag("hedef"));
        {
            rb.isKinematic = false;
            rb.useGravity = false;
            rb.constraints = RigidbodyConstraints.FreezePosition;
        }
    }
    /* public void OnCollisionEnter2D(Collision2D col)//Güzel bir başlangıç fakat senin collider'ın 3D bu method'un 3d versionunu kullanman gerekiyor
    {
        if (col.gameObject.tag == "target")//Kod yazarken alttaki gibi boşluk bırakmamaya çalış :)


        {
            rb.isKinematic = true;// gayet doğru
            rb.velocity=Vector3.zero;
        }
        */
    }


