using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clogBlockShot : MonoBehaviour {
    public float speed = 10.0f;
    // Use this for initialization
    void Start () {
        rigidbody2d = GetComponent<Rigidbody2D>();
    }

    Rigidbody2D rigidbody2d;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("boundary"))
        {
            rigidbody2d.gameObject.SetActive(false);
        }
        if (other.gameObject.CompareTag("bullet") == true)
        {
            rigidbody2d.gameObject.SetActive(false);
        }


    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("bullet") == true)
        {
            rigidbody2d.gameObject.SetActive(false);
        }
        /*if (other.gameObject.CompareTag("player"))
        {
            Player player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
            //player.transform.position += Vector3.down * speed * Time.deltaTime;
            Vector3 move = Vector2.right * Time.deltaTime * speed;
            move = (-1) * move;            
            player.transform.Translate(move);
            /*if (initPosition - transform.position.x > 35 || initPosition - transform.position.x < -35)
            {
                Destroy(gameObject);
            }
        }*/
    }
}
