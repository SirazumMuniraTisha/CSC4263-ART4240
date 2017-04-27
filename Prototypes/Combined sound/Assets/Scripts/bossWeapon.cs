using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossWeapon : MonoBehaviour
{
    public GameObject bullet;
    public Transform firePoint;

  
    float dt1;
    private float fireRate = 5f;
    private float range = 20;
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
	{Debug.Log("working1");
        if (target != null)
		{Debug.Log("working2");
            float distance = Vector2.Distance(transform.position, target.position);
            
                if (Time.time > nextFire)
			{Debug.Log("working3");
				Debug.Log(distance);
                    if (distance <= range)
                    {
                    Debug.Log("working");
                        nextFire = Time.time + fireRate;
                        Instantiate(bullet, firePoint.position, firePoint.rotation);
                    }


                }
        }
    }
}
