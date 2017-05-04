using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxManager : MonoBehaviour
{
    public GameObject boxPrefab;
    public Box box;
    public float rotationSpeed = 5;
    public float movementSpeed = 10;

    private float rotationX = 0;

    // Use this for initialization
    void Start()
    {
        // Spawn a new box
        GameObject clone = Instantiate(boxPrefab);
        clone.transform.position = transform.position;

    }


    // Update is called once per frame
    void Update()
    {
        box.SetWidth(100);
        box.SetHeight(150);
        box.SetDepth(100);

        box.SetRotation(Quaternion.Euler(new Vector3(rotationX, 270, 0)));
        rotationX += rotationSpeed * Time.deltaTime;

        Vector3 pos = box.GetPosition();
        box.SetPosition(new Vector3(pos.x + movementSpeed * Time.deltaTime, 0, 100));
    }
}
