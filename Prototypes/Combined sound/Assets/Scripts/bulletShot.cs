using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bulletShot: MonoBehaviour {

	private float speed = 40f;
	//public GameObject enemyDeath;
	float initPosition;
	float initRotation;
    Text consultText;

    void Start() {
		initPosition = transform.position.x;
		initRotation = transform.rotation.z;
	}
	void Update () {
		Vector3 move = Vector2.right * Time.deltaTime * speed;
		if (initRotation == 180) {
			move = (-1) * move;
		}
		transform.Translate (move);
		if (initPosition - transform.position.x >25 || initPosition - transform.position.x < -25) {
			Destroy (gameObject);
		}

    }

	void OnCollisionEnter2D(Collision2D other)
	{
		if (other.gameObject.tag == "Enemy") {        
            Destroy(other.gameObject);
			Destroy (gameObject);
		} else if (other.gameObject.tag == "clog")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
		} else if (other.gameObject.tag == "Useful")
		{
			Destroy(other.gameObject);
			Destroy(gameObject);
		}
	}

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

}
