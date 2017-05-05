using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EWeapon2 : MonoBehaviour {

    public GameObject enemyBullet;
    //public float shootRate = 0.25f;
    //private float shootCoolDown;


    // Use this for initialization
    private float speed = 19f;
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
        if (initPosition - transform.position.x > 13 || initPosition - transform.position.x < -13)
        {
            Destroy(gameObject);
        }

    }
    private void OnCollisionEnter2D(Collision2D other)
    {

        if (other.gameObject.tag == "clog")
        {
            Destroy(gameObject);
        }
        else if (other.gameObject.tag == "Useful")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
        else if (other.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
    }

}
