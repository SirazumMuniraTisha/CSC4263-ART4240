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
	Quaternion initRotation;
	Sprite CapsuleRight;
	public Sprite ShieldCapiRight, ShieldCapiLeft, CapsuleLeft, DeadCapsule;
	public float speed = 12.0f;
    public Boundary boundary;
	public int health = 5, count = 0;
    private Player player;
	public AudioSource Ouch, Dead, BackMusic;
    void Start() {
		initRotation = transform.rotation;
		Capsule = (SpriteRenderer)GetComponent("SpriteRenderer");
		CapsuleRight = Capsule.sprite;
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
    }
	void Update () {
		gameObject.transform.rotation = initRotation;
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
	void OnCollisionEnter2D(Collision2D other)
	{
       
            if (other.gameObject.tag == "Enemy")
            {
                count += 1;
                print("ouch");
                if (count == 6 && player.curhealth > 0)
                {
                    health -= 1;
                    player.curhealth -= 1;
                    if (player.curhealth < 0)
                        player.curhealth = 0;
                    count = 0;
                }

                else if (count >= 1 && player.curhealth <= 0)
                    health -= 1;

                if (health > 0)
                    Ouch.Play();
                else
                    Dead.Play();
                print(health);

            }
            else if (other.gameObject.tag == "BBossBull")
            {
                print("ouch");
                health -= 1;
                if (health > 0)
                    Ouch.Play();
                else
                    Dead.Play();
                print(health);

            }
            else if (other.gameObject.tag == "eb")
            {
                print("ouch");
                health -= 1;
                if (health > 0)
                    Ouch.Play();
                else
                    Dead.Play();
                print(health);

            }

   }
    

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "Useful" && health < 5) {
            Debug.Log(health);
            health = 5;
            //count += 1;
			Destroy (other.gameObject);
            Debug.Log(health);
        }
    }
}

