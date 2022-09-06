using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hareketet : MonoBehaviour
{
    public int puan = 0;
    public Text puangoster;

    [Header("MOVEMENT")] 
    [SerializeField] private float sideMovementSpeed;
    [SerializeField] private float forwardMovementSpeed;

    void start()

    {
        Cursor.lockState = CursorLockMode.Locked;// ekranı kitlemeye yarıyormus sanırım.

    }
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
            transform.Translate(Vector3.right * Time.deltaTime * forwardMovementSpeed);
        if (Input.GetKey(KeyCode.A))
            transform.Translate(-1*Time.deltaTime * forwardMovementSpeed,0,0);
        if (Input.GetKey(KeyCode.W))
            transform.Translate(0,0,Time.deltaTime * sideMovementSpeed);
        if (Input.GetKey(KeyCode.S))
            transform.Translate(0,0,-1*Time.deltaTime * sideMovementSpeed);
        

        // EGE'NİN KODU
        // if (Input.GetKey(KeyCode.H))
        // {
        //     transform.Rotate(0,1*Time.maximumParticleDeltaTime * rotationSpeed ,0);
        // }
        // if (Input.GetKey(KeyCode.G))
        // {
        //     transform.Rotate(0,-1*Time.maximumParticleDeltaTime * rotationSpeed,0);
        // }

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
