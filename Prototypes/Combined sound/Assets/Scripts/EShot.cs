using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EShot : MonoBehaviour {
    public GameObject bullet;
    public Transform firePoint;
    SpriteRenderer BA3;
    public Sprite BA1oclock;
    public Sprite BA3oclock;
    public Sprite BA5oclock;
    public Sprite BA7oclock;
    public Sprite BA9oclock;

    Sprite init;
    float dt1;
    void Start()
    {
        BA3 = (SpriteRenderer)GetComponent("SpriteRenderer");
        init = BA3.sprite;
    }

    void Update()
    {
        
            dt1 = DateTime.Now.Second;
        /**
                    
                    if (BA3.sprite == BA3oclock)
                    {
                        
                        Instantiate(bullet, firePoint.position, new Quaternion(0, 0, 0, 0));
                    }
                    
                    if (BA3.sprite == BA9oclock)
                    {

                        Instantiate(bullet, firePoint.position, new Quaternion(0, 0, 180, 0));
                    }

               */
        Instantiate(bullet, firePoint.position, Quaternion.identity);
    }
}
