﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followTargetForMinimapCamera : MonoBehaviour {

    public Transform target;

    void LateUpdate () {
        transform.position = new Vector2(target.position.x, target.position.y);
	}
}