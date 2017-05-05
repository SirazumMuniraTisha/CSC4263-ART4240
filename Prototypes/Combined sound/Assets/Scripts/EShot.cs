using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EShot : MonoBehaviour {
    public GameObject bullet;
    public Transform firePoint;
    SpriteRenderer BA3;
    GameObject temp;
    Sprite init;
    float dt1;
    public float fireRate = 1f;
    public float range = 5f;
    private Transform target;

    private float nextFire;

    void Start()
    {
        BA3 = (SpriteRenderer)GetComponent("SpriteRenderer");
		if(GameObject.FindGameObjectWithTag ("Player")!=null)
        	target = GameObject.FindGameObjectWithTag("Player").transform;
        init = BA3.sprite;
        
    }

    void Update()
    {

        Invoke("ShootBull", 0f);
           
    }

    void ShootBull()
    {
		if (target != null) {
			float distance = Vector2.Distance (transform.position, target.position);
			if (Time.time > nextFire) {
				if (distance <= range) {

                        // = DateTime.Now.Second;
                        nextFire = Time.time + fireRate;
                        Instantiate(bullet, transform.position + 1.0f * transform.forward, transform.rotation);

				}

				//GameObject instance= Instantiate(bullet);
			}
		}
    }
}
