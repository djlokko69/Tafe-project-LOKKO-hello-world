using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerup : MonoBehaviour
{
    // Public
    public Color startColor = Color.red;
    public Color endColor = Color.blue;
    public float rotationSpeed = 20f;
    public float colorCycleSpeed = 10f;
    public float bobSpeed = 10;
    public float bobSpread = 5;

    private MeshRenderer rend;
    private float colorTimer = 0;
    private float bobTimer = 0;
    private float startY = 0;


    // Use this for initialization
    void Start()
    {
        rend = GetComponent<MeshRenderer>();
        startY = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        ChangeColor();  // Calling a function
        Rotate();
        Bob();
    }


    void Rotate()
    {
        transform.Rotate(new Vector3(0, rotationSpeed * Time.deltaTime, 0));
    }

    void ChangeColor()  // Defining a function
    {
        Material mat = rend.material;
        colorTimer += colorCycleSpeed * Time.deltaTime;
        float lerp = Mathf.PingPong(colorTimer, 1.0f) / 1.0f;
        mat.color = Color.Lerp(startColor, endColor, lerp);
    }


    void Bob()
    {
        bobTimer += bobSpeed * Time.deltaTime;
        float lerp = Mathf.PingPong(bobTimer, 1.0f) / 1.0f;
        //Get the position of powerup
        Vector3 position = transform.position; // Copy the position
        // Change the position
        position.y = startY + Mathf.Lerp(-bobSpread, bobSpread, lerp);
        transform.position = position; // Set the position

    }


}
