using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossWeapon : MonoBehaviour
{
    public GameObject bullet;
    public GameObject ene;
    public Transform firePoint, bacpoint, point2;
    float dt1;
    private float fireRate = 2f;
    private float range = 40;
    private Transform target;
    private float nextFire = 0.0f;

    void Start()
    {
        if (GameObject.FindGameObjectWithTag("Player") != null)
            target = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        Invoke("ShootBull", .5f);
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
					Instantiate(ene, bacpoint.position, bacpoint.rotation);
					Instantiate(ene, point2.position, point2.rotation);
                    }

            }
        }
    }
}
