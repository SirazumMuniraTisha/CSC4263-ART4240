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

    private float nextFire;

    void Start()
    {
        BA3 = (SpriteRenderer)GetComponent("SpriteRenderer");
        init = BA3.sprite;
        
    }

    void Update()
    {
        Invoke("ShootBull", 5f);
           
    }

    void ShootBull()
    {
        if (Time.time > nextFire)
        {
            // = DateTime.Now.Second;
            nextFire = Time.time + fireRate;
            Instantiate(bullet, firePoint.position, Quaternion.identity);

            //GameObject instance= Instantiate(bullet);
        }

    }
}
