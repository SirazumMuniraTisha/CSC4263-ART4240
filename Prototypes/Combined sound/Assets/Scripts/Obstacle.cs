using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour {
	Vector2 initPosition;
	Quaternion initRotation;
	// Use this for initialization
	void Start () {
		initPosition = transform.position;
		initRotation = transform.rotation;
	}

	// Update is called once per frame
	void Update () {
		gameObject.transform.position = initPosition;
		gameObject.transform.rotation = initRotation;
	}
}
