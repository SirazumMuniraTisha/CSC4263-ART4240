using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class Boundary
{
    public float xMin, xMax, yMin, yMax;
}


public class Movement : MonoBehaviour {
	SpriteRenderer Capsule;
	Sprite CapsuleRight;
	public Sprite ShieldCapiRight, ShieldCapiLeft, CapsuleLeft, DeadCapsule;
	public float speed = 10.0f;
    public Boundary boundary;
	public int health = 100, count = 0;
    private Player player;
	public AudioSource Ouch, Dead, BackMusic;
    void Start() {
		Capsule = (SpriteRenderer)GetComponent("SpriteRenderer");
		CapsuleRight = Capsule.sprite;
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
    }
	void Update () {
		if (health > 0) {
			if (Input.GetKey (KeyCode.RightArrow)) {
				if (player.curhealth == 0)
					Capsule.sprite = CapsuleRight;
				else
					Capsule.sprite = ShieldCapiRight;

				transform.position += Vector3.right * speed * Time.deltaTime;
			}
			if (Input.GetKey (KeyCode.LeftArrow)) {
				if (player.curhealth == 0)
					Capsule.sprite = CapsuleLeft;
				else
					Capsule.sprite = ShieldCapiLeft;
			
				transform.position += Vector3.left * speed * Time.deltaTime;
			}
			if (Input.GetKey (KeyCode.UpArrow)) {
				transform.position += Vector3.up * speed * Time.deltaTime;
			}
			if (Input.GetKey (KeyCode.DownArrow)) {
				transform.position += Vector3.down * speed * Time.deltaTime;
			}
			transform.position = new Vector3 (
				Mathf.Clamp (transform.position.x, boundary.xMin, boundary.xMax),
				Mathf.Clamp (transform.position.y, boundary.yMin, boundary.yMax),
				0.0f
			);
		}
		else {
			BackMusic.Stop ();
			Capsule.sprite = DeadCapsule;
			Invoke("KillCapi", 1);
		}	
    }
	void KillCapi(){		
		Destroy (gameObject);
	}
       
        //if (Input.GetKey (KeyCode.RightArrow)) {
        //	transform.position += Vector3.right * speed * Time.deltaTime;
        //	print ((float)(firePoint.position.x - Middle.position.x));
        //Capsule.sprite = (Sprite) CapsuleRight;
        //}
        //if (Input.GetKey (KeyCode.UpArrow)) {
        //	transform.position += Vector3.up * speed * Time.deltaTime;
        //}
        //if (Input.GetKey (KeyCode.DownArrow)) {
        //	transform.position += Vector3.down * speed * Time.deltaTime;
        //}
	void OnCollisionEnter2D(Collision2D other)
	{
		if (other.gameObject.tag == "Enemy") {
			print ("ouch");
			health -= 10;
			if(health > 0)
				Ouch.Play ();
			else
				Dead.Play ();
			print (health);
			//if (health == 0) {
			//	Destroy (gameObject);
			//}	
		}
	}

	/**
	 * code to trigger power upgrade
	 */
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "Useful" && health < 105) {
            Debug.Log(health);
            health += 5;
            //count += 1;
			Destroy (other.gameObject);
            Debug.Log(health);
        }
	}

    }

