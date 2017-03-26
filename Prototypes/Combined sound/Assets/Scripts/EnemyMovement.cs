using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {
	public float speed = 5f;
	Rigidbody2D r2d;
	// Use this for initialization
	void Start () {
		r2d = GetComponent<Rigidbody2D>();
		float y = r2d.velocity.x;
		y = speed;
		r2d.angularVelocity = Random.Range (-.1f, .1f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	private void OnBecameInvisible()
	{
		Destroy(gameObject);
	}
}
