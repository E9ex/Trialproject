using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hareketet : MonoBehaviour
{
    public int puan = 0;
    public Text puangoster;
    public Transform top;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(1*Time.deltaTime,0,0);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(-1*Time.deltaTime,0,0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(0,0,1*Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(0,0,-1*Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.G))
        {
            transform.Rotate(0,1*Time.maximumParticleDeltaTime,0);
        }
        if (Input.GetKey(KeyCode.H))
        {
            transform.Rotate(0,-1*Time.maximumParticleDeltaTime,0);
        }
        if (Input.GetKey(KeyCode.O))
        {
            transform.Rotate(0,0,1*Time.maximumParticleDeltaTime);
        }
        if (Input.GetKey(KeyCode.L))
        {
            transform.Rotate(0,0,-1*Time.maximumParticleDeltaTime);
        }
        
        
        
      //  top.Rotate(0,Input.GetAxis("Horizontal"),0);
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "mavi")
        {
            puan++;
            puangoster.text = "puan" + puan;
        }
    }
}
