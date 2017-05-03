using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossBullet : MonoBehaviour {

    // Use this for initialization
    public float speed = 30f;
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
        if (initPosition - transform.position.x >20 || initPosition - transform.position.x < -20)
        {
            Destroy(gameObject);
        }


    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {

            Destroy(gameObject);
        }
        else if (other.gameObject.tag == "clog")
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




