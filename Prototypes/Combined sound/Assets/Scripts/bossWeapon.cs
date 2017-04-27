using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossWeapon : MonoBehaviour
{
    public GameObject bullet;
    public Transform firePoint;
    float dt1;
    private float fireRate = 5f;
    private float range = 40;
    private Transform target;
    private float nextFire;

    void Start()
    {
        if (GameObject.FindGameObjectWithTag("Player") != null)
            target = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        Invoke("ShootBull", 1f);
    }

    void ShootBull()
	{
        if (target != null)
		{
            float distance = Vector2.Distance(transform.position, target.position);
            if (Time.time > nextFire)
			{
				if (distance <= range)
                    {
                        nextFire = Time.time + fireRate;
                        Instantiate(bullet, firePoint.position, firePoint.rotation);
                    }
            }
        }
    }
}
