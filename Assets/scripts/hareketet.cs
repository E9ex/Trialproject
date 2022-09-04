using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hareketet : MonoBehaviour
{
    public Vector3 ilkros,ilkross,sonross ,sonros;
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


        if (Input.GetMouseButton(1))
        {


            ilkross = Input.mousePosition;
        }
        else if (Input.GetMouseButton(1))
            {
                transform.Rotate(0,0,1*Time.maximumParticleDeltaTime);
                float zrotation = Mathf.Clamp(transform.rotation.z,-5.52f, 5.52f);
                transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.eulerAngles.y, zrotation);
                sonrosa = Input.mousePosition;
                float farkkk = sonrosa - ilkross;
                transform.rotation(0, 0, farkk * Time.deltaTime);
                
            }
        
        
           
            

        

        if (Input.GetMouseButton(0))
        {
            ilkros = Input.mousePosition;
        }

      else  if (Input.GetMouseButton(0))
        {
            
            transform.Rotate(0,0,-1*Time.maximumParticleDeltaTime);
            float zzrotation = Mathf.Clamp(transform.rotation.z,-5.52f, 5.52f);
            transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y, zzrotation);
            sonros = Input.mousePosition;
            float farkk = sonros - ilkros;
            transform.rotation(0, 0, farkk * Time.deltaTime);
        }
        
            

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
