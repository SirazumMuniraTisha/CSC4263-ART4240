﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletShot: MonoBehaviour {

	public float speed = 6;
	//public GameObject enemyDeath;
	float initPosition;
	float initRotation;
	void Start() {
		initPosition = transform.position.x;
		initRotation = transform.rotation.z;
	}
	void Update () {
		Vector3 move = Vector2.right * Time.deltaTime * speed;
		if (initRotation == 180) {
			move = (-1) * move;
		}
		transform.Translate (move);
		if (initPosition - transform.position.x > 5 || initPosition - transform.position.x < -5) {
			Destroy (gameObject);
		}
	}

	void OnCollisionEnter2D(Collision2D other)
	{
		if (other.gameObject.tag == "Enemy") {
			print ("shot");
			Destroy (other.gameObject);
			Destroy (gameObject);
		}
	}

}