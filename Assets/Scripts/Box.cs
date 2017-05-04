using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    // Member variables
    private float width = 10;
    private float height = 10;
    private float depth = 10;
    private Vector3 position;
    private Quaternion rotation;

    // Getters
    // <access-specifier> < return-type> <function-name> ( <optional-arguments> )
    // Get Width
    public float GetWidth()
    {
        return width;
    }
    // Get Height
    public float GetHeight()
    {
        return height;
    }
    // Get Depth
    public float GetDepth()
    {
        return depth;
    }
    
    public Vector3 GetPosition()
    {
        return position;
    }

    public Quaternion GetRotation()
    {
        return rotation;
    }

    public Vector3 GetEuler()
    {
        return rotation.eulerAngles;
    }


    //Setters
    public void SetWidth(float a_width)
    {
        // Box's width is going to be set to input width
        width = a_width;
    }
    public void SetHeight(float a_height)
    {
        height = a_height;
    }
    public void SetDepth(float a_depth)
    {
        depth = a_depth;
    }

    public void SetPosition(Vector3 a_position)
    {
        position = a_position;
    }

    public void SetRotation(Quaternion a_rotation)
    {
        rotation = a_rotation;
    }

    public void SetRotation(Vector3 a_euler)
    {
        rotation = Quaternion.Euler(a_euler);
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale = new Vector3(width, height, depth);
        transform.position = position;
        transform.rotation = rotation;
    }
}
