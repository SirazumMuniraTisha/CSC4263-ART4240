using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {
	public float speed = 3f;
	//Rigidbody2D r2d;
	private Transform target;


	// Use this for initialization

	void Start () {

		target = GameObject.FindGameObjectWithTag ("Player").transform;

	}
	
	// Update is called once per frame
	void Update () {
		transform.position = Vector2.MoveTowards (transform.position, target.transform.position, speed * Time.deltaTime);
	}

	void OnCollisionEnter2D(Collision2D other)
	{
		if (other.gameObject.tag == "bullet") {
			Destroy (gameObject);
		}
	}
	private void OnBecameInvisible()
	{
		Destroy(gameObject);
	}
}
