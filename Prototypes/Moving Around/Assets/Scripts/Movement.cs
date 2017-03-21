using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class Boundary
{
    public float xMin, xMax, yMin, yMax;
}


public class Movement : MonoBehaviour
{

    public float speed = 10.0f;
    public Boundary boundary;

    void Update()
    {

        if (Input.GetKey(KeyCode.RightArrow))
        {
            
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += Vector3.up * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += Vector3.down * speed * Time.deltaTime;
        }
        transform.position = new Vector3
       (
           Mathf.Clamp(transform.position.x, boundary.xMin, boundary.xMax),
           Mathf.Clamp(transform.position.y, boundary.yMin, boundary.yMax),
           0.0f

       );
    }


}

