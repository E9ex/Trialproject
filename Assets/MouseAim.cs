using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseAim : MonoBehaviour
{

    public float mouseSensitivity = 100f;

    public Transform playerBody;

    private Vector3 lastPos;

    private float xRotation = 0;
    
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        var mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        var mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;
        
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        var currentPos = Input.mousePosition;
        
        Debug.Log("X Rotation " + (currentPos));

        lastPos = currentPos;
        
        transform.localRotation = Quaternion.Euler(xRotation , 0f, 0f);
        
        playerBody.Rotate(Vector3.up * mouseX);
    }
}
