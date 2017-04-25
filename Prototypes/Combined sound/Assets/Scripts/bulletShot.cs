using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bulletShot: MonoBehaviour {

	public float speed = 20;
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
		if (initPosition - transform.position.x >35 || initPosition - transform.position.x < -35) {
			Destroy (gameObject);
		}
        //consultText = GameObject.FindGameObjectWithTag("consult").GetComponent<Text>();
       // consultText.text = "";
    }

	void OnCollisionEnter2D(Collision2D other)
	{
		if (other.gameObject.tag == "Enemy") {
            Text immunityText = GameObject.FindGameObjectWithTag("immunity").GetComponent<Text>();
            consultText = GameObject.FindGameObjectWithTag("consult").GetComponent<Text>();
            int currentImmunity = int.Parse(immunityText.text.ToString().Substring(16, immunityText.text.ToString().IndexOf("%")-16)) - 5;
            //print(currentImmunity);
            immunityText.text = "Immunity Level: " + currentImmunity.ToString() + "%";
            consultText.text = "You get 10 scores but your immunity level decreased 5 points because of shooting.";
        
            Destroy(other.gameObject);
			Destroy (gameObject);
		} else if (other.gameObject.tag == "clog")
        {
            Destroy(other.gameObject);
        }
	}

}
