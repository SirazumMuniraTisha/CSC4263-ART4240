﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public GameObject player;
    public float speed = 10.0f;


    void Update()
    {
        float xPos = Mathf.Lerp(transform.position.x, player.transform.position.x, speed * Time.deltaTime);
        transform.position = new Vector3(xPos, 0, -10);
    }
}
