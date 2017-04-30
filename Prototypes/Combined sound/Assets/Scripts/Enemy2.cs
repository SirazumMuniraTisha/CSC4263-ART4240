using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2 : MonoBehaviour {
    public GameObject bullet;
    public Transform firePoint;
    SpriteRenderer BA3;
    GameObject temp;
    Sprite BA;
    public Sprite BLeft, BRight;
    float dt1;
    public float fireRate = 10f;
    public float range = 8f;
    private Transform target;

    private float nextFire;

    void Start()
    {
        BA3 = (SpriteRenderer)GetComponent("SpriteRenderer");
        if (GameObject.FindGameObjectWithTag("Player") != null)
            target = GameObject.FindGameObjectWithTag("Player").transform;
        BA = BA3.sprite;

    }

    void Update()
    {

        Invoke("ShootBull", .25f);

    }

    void ShootBull()
    {
        if (target != null)
        {
            float distance = Vector2.Distance(transform.position, target.position);
            if (BA3.sprite == BLeft || BA3.sprite == BRight)
            {
                if (Time.time > nextFire)
                {
                    if (distance <= range)
                    {
                        // = DateTime.Now.Second;
                        nextFire = Time.time + fireRate;
                        Instantiate(bullet, firePoint.position, transform.rotation);
                    }

                    //GameObject instance= Instantiate(bullet);
                }
            }
        }
    }
}
