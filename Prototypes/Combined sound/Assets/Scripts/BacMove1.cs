using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BacMove1 : MonoBehaviour {

	Rigidbody2D rigidBody;
	Vector2 currentPosition;
	Vector2 initPosition;
	void Start () {
		rigidBody = gameObject.GetComponent<Rigidbody2D> ();
		initPosition = gameObject.transform.position;
	}

	void Update () {
		currentPosition = initPosition;
		currentPosition.y = initPosition.y + Mathf.Sin (Time.timeSinceLevelLoad)*2;
		rigidBody.MovePosition (currentPosition);
	}
}
