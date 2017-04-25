using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clogBlockShot : MonoBehaviour {

	// Use this for initialization
	void Start () {
        rigidbody2d = GetComponent<Rigidbody2D>();
    }

    Rigidbody2D rigidbody2d;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("boundary"))
        {
            rigidbody2d.gameObject.SetActive(false);
        } else if ()
        {

        }

    }
}
