using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class bulletScript : MonoBehaviour {

	public GameObject bullet;
	public Transform firePoint;
	public Transform firePointL;
	SpriteRenderer Capsule;
	public Sprite CapsuleLeft;
	public Sprite CapsuleRight;
	public Sprite CapsuleShotL;
	public Sprite CapsuleShotR;
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

			if (Capsule.sprite == CapsuleLeft) {
				Capsule.sprite = CapsuleShotL;
				Instantiate(bullet, firePointL.position, new Quaternion(0,0,180,0));
			}
			if (Capsule.sprite == CapsuleRight) {
				Capsule.sprite = CapsuleShotR;
				Instantiate(bullet, firePoint.position, new Quaternion(0,0,0,0));
			}
			//Capsule.sprite = CapsuleShot;
			GetComponent<AudioSource> ().Play ();

		}
		if (DateTime.Now.Second - dt1 > 0.1f) {
			if (Capsule.sprite == CapsuleShotL) {
				Capsule.sprite = CapsuleLeft;
			}
			if (Capsule.sprite == CapsuleShotR) {
				Capsule.sprite = CapsuleRight;
			}
			//Capsule.sprite = init;
		}

	}


}
