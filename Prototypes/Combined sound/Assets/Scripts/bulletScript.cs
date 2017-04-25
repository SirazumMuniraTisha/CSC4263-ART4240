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
    public Sprite ShieldCapsuleLeft;
    public Sprite ShieldCapsuleRight;
    public Sprite ShieldShootiCapsuleLeft;
    public Sprite ShieldShootiCapsuleRight;
    public Sprite CapsuleShotL;
	public Sprite CapsuleShotR;
    public Player player;
	float dt1;
	void Start()
	{
		Capsule = (SpriteRenderer)GetComponent("SpriteRenderer");
	}

	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Space))
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
            if (Capsule.sprite ==ShieldCapsuleLeft )
            {
                Capsule.sprite = ShieldShootiCapsuleLeft;
                Instantiate(bullet, firePointL.position, new Quaternion(0, 0, 180, 0));
            }
            if (Capsule.sprite == ShieldCapsuleRight )
            {
                Capsule.sprite = ShieldShootiCapsuleRight;
                Instantiate(bullet, firePoint.position, new Quaternion(0, 0, 0, 0));
            }
            //Capsule.sprite = CapsuleShot;
            GetComponent<AudioSource> ().Play ();

		}
		if (DateTime.Now.Second - dt1 > 0.1f) {
            if (player.curhealth == 0) {
                if (Capsule.sprite == CapsuleShotL) {
                    Capsule.sprite = CapsuleLeft;
                }
                if (Capsule.sprite == CapsuleShotR) {
                    Capsule.sprite = CapsuleRight;
                }
            }
            else
            {
                if (Capsule.sprite == ShieldShootiCapsuleLeft)
                {
                    Capsule.sprite = ShieldCapsuleLeft;
                }
                if (Capsule.sprite == ShieldShootiCapsuleRight)
                {
                    Capsule.sprite = ShieldCapsuleRight;
                }
            }
		}

	}
}
