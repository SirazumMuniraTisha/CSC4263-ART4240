using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletShot : MonoBehaviour {

	public float speed = 6;
	Rigidbody2D r2d;
	public GameObject enemyDeath;

	// Use this for initialization
	void Start () {
		r2d = GetComponent<Rigidbody2D>();
		r2d.velocity = new Vector2(speed, 0);
	}

	// Update is called once per frame
	void Update () {

	}

	void OnCollisionEnter2D(Collision2D other)
	{
		
		if (other.gameObject.tag == "Enemy") {
			Destroy (other.gameObject);
			Destroy (gameObject);
		}

	}



}
