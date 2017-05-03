using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {
	private float speed = 1f;
    private float range;
    public Rigidbody2D rb;
    private Transform target;


	// Use this for initialization

	void Start () {
        rb = GetComponent<Rigidbody2D>();
        if (GameObject.FindGameObjectWithTag ("Player")!=null)
			target = GameObject.FindGameObjectWithTag ("Player").transform;

	}
	
	// Update is called once per frame
	void Update () {
        rb.freezeRotation =true;
		if (GameObject.FindGameObjectWithTag ("Player") != null) {
			range = Vector2.Distance (transform.position, target.transform.position);
			if (range <= 10f) {
				Vector2 velocity = new Vector2 ((transform.position.x - target.transform.position.x) * speed, (transform.position.y - target.transform.position.y) * speed);
				GetComponent<Rigidbody2D> ().velocity = -velocity;
			}
		}
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
