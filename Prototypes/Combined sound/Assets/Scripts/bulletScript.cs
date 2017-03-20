using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class bulletScript : MonoBehaviour {

	public GameObject bullet;
	public Transform firePoint;
	SpriteRenderer Capsule;
	public Sprite CapsuleShot;
	Sprite init;
	float dt1;
	void Start()
	{
		Capsule = (SpriteRenderer)GetComponent("SpriteRenderer");
		init = Capsule.sprite;
	}

	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Return))
		{
			dt1 = DateTime.Now.Second;
			Instantiate(bullet, firePoint.position, firePoint.rotation);
			Capsule.sprite = CapsuleShot;
			GetComponent<AudioSource> ().Play ();

		}
		if (DateTime.Now.Second - dt1 > 0.1f) {
			Capsule.sprite = init;
		}

	}


}
