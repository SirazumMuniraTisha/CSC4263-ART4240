using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TcellMove : MonoBehaviour {

    public float speed;
    Rigidbody2D rigidbody2d;

    void Awake()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        rigidbody2d.velocity = new Vector2(speed * -1, 0f);
    }
}
