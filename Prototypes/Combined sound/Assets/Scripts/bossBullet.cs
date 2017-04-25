using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossBullet : MonoBehaviour {
    public GameObject enemyBullet;
 


    // Use this for initialization
    public float speed = 50;
    //public GameObject enemyDeath;
    float initPosition;
    float initRotation;

    void Start()
    {
        initPosition = transform.position.x;
        initRotation = transform.rotation.z;

    }
    void Update()
    {
        Vector3 move = Vector2.right * Time.deltaTime * speed;
        //gameObject.GetComponent<Rigidbody2D>().velocity = transform.forward * speed;
        if (initRotation == 180)
        {
            move = (-1) * move;
        }
        transform.Translate(move);
        if (initPosition - transform.position.x > 20 || initPosition - transform.position.x < -20)
        {
            Destroy(gameObject);
        }

    }
}
