﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingRightLeft : MonoBehaviour {

    public float speed = 10.0f;
    void Update()
    {
        float x = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float y = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        transform.Translate(0, -x, y);
    }
}
