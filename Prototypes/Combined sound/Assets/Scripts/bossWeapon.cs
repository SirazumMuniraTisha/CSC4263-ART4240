using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossWeapon : MonoBehaviour
{

    public GameObject bullet;
    public Transform [] firePoint;
    //public Transform firePoint2;
    //public Transform firePoint3;
  //  public Transform firePoint1;
    

    GameObject temp;
    Sprite init;
    float dt1;
    private float fireRate = 1f;
    private float range = 50f;
    private Transform target;

    private float nextFire;
    private Transform boss;
    private float timer;

    void Start()
    {
        
        if (GameObject.FindGameObjectWithTag("Player") != null)
            target = GameObject.FindGameObjectWithTag("Player").transform;
      


    }

    void Update()
    {

        Invoke("ShootBull", 0.5f);

    }

    void ShootBull()
    {
        if (target != null)
        {
            //boss = GameObject.FindGameObjectWithTag("Boss").transform;
            float distance = Vector2.Distance(transform.position, target.position);
            /**
            if (Time.time > nextFire)
                {
                    //nextFire = Time.time + fireRate;
    */
                    if (distance <= range)
                    {
                        // = DateTime.Now.Second;
                      //  nextFire = Time.time + fireRate;
                       int firePointIndex = Random.Range(0, firePoint.Length);
                       Instantiate(bullet, firePoint[firePointIndex].position, firePoint[firePointIndex].rotation);
             
                       // Instantiate(bullet, firePoint1.position, firePoint1.rotation);
                      //  Instantiate(bullet, firePoint2.position, firePoint2.rotation);
                        //Instantiate(bullet, firePoint3.position, firePoint3.rotation);
                    }

                    //GameObject instance= Instantiate(bullet);
               // }
        }
    }
}