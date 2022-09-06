using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hareketet : MonoBehaviour
{
    public Vector3 ilkros,ilkross,sonrosa ,sonros;
    public int puan = 0;
    public Text puangoster;
    public Transform top;
    public Transform camera;
    public Transform playerBody;

    [Header("MOVEMENT")] 
    [SerializeField] private float sideMovementSpeed;
    [SerializeField] private float forwardMovementSpeed;

    [Header("ROTATE")] 
    [SerializeField] private float rotationSpeed;
    [SerializeField] private Vector3 lastMouseRot;

    [SerializeField] private float egeRotationSpeed;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.right * Time.deltaTime * forwardMovementSpeed);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(-1*Time.deltaTime * forwardMovementSpeed,0,0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(0,0,Time.deltaTime * sideMovementSpeed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(0,0,-1*Time.deltaTime * sideMovementSpeed);
        }
        
        

        // var delta = ((Input.mousePosition) - lastMouseRot).normalized;
        //
        // Debug.Log("Rotation " + delta);
        //
        // transform.Rotate(Vector3.up * delta.x * rotationSpeed * Time.deltaTime);
        //
        // lastMouseRot = Input.mousePosition;



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
        
        
        
      //  top.Rotate(0,Input.GetAxis("Horizontal"),0);
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "mavi")
        {
            puan++;
            puangoster.text = "puan" + puan;
        }
    }
}
