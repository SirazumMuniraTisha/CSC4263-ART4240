using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletShot: MonoBehaviour {

	public float speed = 6;
	//public GameObject enemyDeath;
	float initPosition;
	void Start() {
		initPosition = transform.position.x;
	}
	void Update () {
		
		transform.Translate (Vector2.right * Time.deltaTime * speed);
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
