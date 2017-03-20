using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {
	SpriteRenderer Capsule;
	Sprite CapsuleRight;
	public Sprite CapsuleLeft;
	public float speed = 10.0f;

	void Start() {
		Capsule = (SpriteRenderer)GetComponent("SpriteRenderer");
		CapsuleRight = Capsule.sprite;
	}
	void Update () {

		float x = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
		float y = Input.GetAxis("Vertical") * speed * Time.deltaTime;
		transform.Translate (x, y, 0);
		if(Input.GetKey(KeyCode.RightArrow)){
			Capsule.sprite = CapsuleRight;
		}
		if (Input.GetKey (KeyCode.LeftArrow)) {
			Capsule.sprite = CapsuleLeft;
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

	}
}
