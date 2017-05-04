using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonCamera : MonoBehaviour
{
    public float mouseSensitivity = 1.0f;

    private float yaw = 0;
    private float pitch = 0;


    // Use this for initialization
    void Start()
    {
        HideCursor(true);
    }

    // Update is called once per frame
    void Update()
    {
        Rotation();
        // Check if we pressed Escape
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            //Unhide the cursor
            HideCursor(false);
        }

        // If we press the Left Mouse button
        if(Input.GetMouseButtonDown(0))
        {
            // Hide the cursor
            HideCursor(true);
        }

    }

    void Rotation()
    {
        // Get the mouse coordinates
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        pitch -= mouseY * mouseSensitivity;
        yaw += mouseX * mouseSensitivity;

        // Apply rotation
        transform.localEulerAngles = new Vector3(pitch, 0, 0);
        transform.parent.eulerAngles = new Vector3(0, yaw, 0);


    }

    void HideCursor(bool isHiding)
    {
        if(isHiding)
        {
            // Lock & Hide the cursor
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;

        }
        else
        {
            // Unlock & Unhide the cursor
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;

        }
    }


}
