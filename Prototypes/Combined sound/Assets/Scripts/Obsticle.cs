using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obsticle : MonoBehaviour {
	Rigidbody2D obsticle;

	// Use this for initialization
	void Start () {
		obsticle = gameObject.GetComponent<Rigidbody2D> ();
	}

	// Update is called once per frame
	void Update () {
		
	}
}
