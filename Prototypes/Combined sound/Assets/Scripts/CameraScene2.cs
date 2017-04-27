﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScene2 : MonoBehaviour {

    public GameObject player;
    Vector3 offset;

    void Start()
    {
        offset = transform.position - player.transform.position;
    }


    void Update()
    {
        transform.position = player.transform.position + offset;
    }
}
