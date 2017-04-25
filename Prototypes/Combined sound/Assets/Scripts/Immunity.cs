using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Immunity : MonoBehaviour
{


    public Sprite[] HeartSprites;

    public Image HeartUI;

    private Player player;
    public AudioSource Ouch;
    private float health;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
    }

    void Update()
    {
        HeartUI.sprite = HeartSprites[player.curhealth];
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            print("ouch");
            Ouch.Play();
            health -= 5;
            print(health);

        }
        else if (other.gameObject.tag == "EnemyBull")
        {
            print("ouch");
            Ouch.Play();
            health -= 10;
            print(health);

        }
        else if (other.gameObject.tag == "BBossBull")
        {
            print("ouch");
            Ouch.Play();
            health -= 15;
            print(health);

        }
        if (health == 0)
        {
            Destroy(gameObject);
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Useful" && health < 105)
        {
            Debug.Log(health);
            health += 5;
            //count += 1;
            Destroy(other.gameObject);
            Debug.Log(health);
        }
    }
}

