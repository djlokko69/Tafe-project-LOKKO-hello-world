using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Public:
    public float movementSpeed = 20f;
    public int health = 100;
    public int stamina = 100;
    public int armor = 100;

    // Private:
    private CharacterController controller;
    private Vector3 movement;

    // Use this for initialization
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }


    void Movement()
    {
        // Reset the movement every frame
        movement = Physics.gravity * Time.deltaTime;

        // Get input from user
        // -1 = left or 'a'
        //  1 = right or 'd' 
        float inputHoriz = Input.GetAxis("Horizontal");
        // If we pressed A/D or Left/Right
        if(inputHoriz != 0)
        {
            movement += transform.right * inputHoriz * movementSpeed * Time.deltaTime;
        }

        // -1 = release or 's'
        //  1 = forward or 'w'
        float inputVert = Input.GetAxis("Vertical");
        // If we pressed W/S or Up/Down
        if (inputVert != 0)
        {
            movement += transform.forward * inputVert * movementSpeed * Time.deltaTime;
        }

        // Offset the player by movement this frame
        // Apply the movement to the controller
        controller.Move(movement);

    }
}
