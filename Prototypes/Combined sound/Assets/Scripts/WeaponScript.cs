using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponScript : MonoBehaviour {

    public GameObject enemyBullet;
    //public float shootRate = 0.25f;
    //private float shootCoolDown;


    // Use this for initialization
    public float speed = 6;
    //public GameObject enemyDeath;
    float initPosition;
    float initRotation;
   
    void Start()
    {
        initPosition = transform.position.x;
        initRotation = transform.rotation.z;
     //   gameObject.GetComponent<Rigidbody2D>().velocity = transform.forward * speed;
    }
    void Update()
    {
        Vector3 move = Vector2.right * Time.deltaTime * speed;
        gameObject.GetComponent<Rigidbody2D>().velocity = transform.forward * speed;
        if (initRotation == 180)
        {
            move = (-1) * move;
        }
        transform.Translate(move);
        if (initPosition - transform.position.x > 5 || initPosition - transform.position.x < -5)
        {
            Destroy(gameObject);
        }

    }


    // Instantiate(enemyBullet, transform.position, Quaternion.identity);
}
