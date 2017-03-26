using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {
	public float speed = 8f;
	//Rigidbody2D r2d;
	private Transform target;
//	public Transform enemy;
	public float rotationSpeed = 3f;

	// Use this for initialization

	void Start () {

		target = GameObject.FindGameObjectWithTag ("Player").transform;

	}
	
	// Update is called once per frame
	void Update () {
		transform.position = Vector2.MoveTowards (transform.position, target.transform.position, speed * Time.deltaTime);
	}

	private void OnBecameInvisible()
	{
		Destroy(gameObject);
	}
}
