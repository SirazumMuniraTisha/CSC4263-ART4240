using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public Player(){}
    public int curhealth = 0;
    public int maxhealth = 5;
	public AudioSource Swallow;
    private Movement player;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Movement>();
        curhealth = 0;
    }

    void Update()
    {
        if (curhealth >= maxhealth)
            curhealth = maxhealth;

    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Tcell")
        {
            curhealth += 1;
            if (player.health < 5)
                player.health = 5;
			Swallow.Play ();
            Destroy(other.gameObject);
        }
    }
}
