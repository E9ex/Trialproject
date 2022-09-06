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
    private float Xrotation = 0f;

    void start()

    {
        Cursor.lockState = CursorLockMode.Locked;// ekranı kitlemeye yarıyormus sanırım.

    }
    

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

        
        
        
            
            // transform.Rotate(0,0,1*Time.maximumParticleDeltaTime);
            // float zrotation = Mathf.Clamp(transform.rotation.z,-5.52f, 5.52f);
            // transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.eulerAngles.y, zrotation);
            
            // Vector3 farkkk = sonrosa - ilkross;
            // var newRotate = new Vector3( farkkk.y, -farkkk.x,0 ) * Time.deltaTime * egeRotationSpeed;
            // camera.Rotate(Vector3.forward * farkkk.y);
            // camera.Rotate(Vector3.down * farkkk.x);
// videodan gordugum kdriyla yazdim bişiler.
            float inputX = Input.GetAxis("Mouse X") * Time.deltaTime * egeRotationSpeed;
            float inputY = Input.GetAxis("Mouse Y") * Time.deltaTime * egeRotationSpeed;
            Xrotation  -= inputY;
        
            
            Xrotation = Mathf.Clamp(Xrotation, -90f, 90f);
           // inputY = Mathf.Clamp(-inputY, -90, 90);
            transform.localRotation = Quaternion.Euler(Xrotation, 0f,0f) ;
            playerBody.Rotate(Vector3.up * inputX);
            // transform.Rotate(inputX * Vector3.down);
           
            
        //
        //
        // if (Input.GetMouseButton(0))
        // {
        //     ilkros = Input.mousePosition;
        //     
        //     transform.Rotate(0,0,-1*Time.maximumParticleDeltaTime);
        //     float zzrotation = Mathf.Clamp(transform.rotation.z,-5.52f, 5.52f);
        //     transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y, zzrotation);
        //     sonros = Input.mousePosition;
        //     float farkk = sonros - ilkros;
        //     transform.rotation(0, 0, farkk * Time.deltaTime);
        // }
        //


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
