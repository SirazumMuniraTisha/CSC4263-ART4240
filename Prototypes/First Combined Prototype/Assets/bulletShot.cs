using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletShot : MonoBehaviour {

	public float speed = 6;
	Rigidbody2D r2d;

	// Use this for initialization
	void Start () {
		r2d = GetComponent<Rigidbody2D>();
		r2d.velocity = new Vector2(0, speed);
	}

	// Update is called once per frame
	void Update () {

	}
	private void OnBecameInvisible()
	{
		Destroy(gameObject);
	}
}
