using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BacMove : MonoBehaviour {
	public float times;
	public int direction; //x=1, y=2
	Rigidbody2D rigidBody;
	Vector2 currentPosition, initPosition;
	float curr, init;
	void Start () {
		rigidBody = gameObject.GetComponent<Rigidbody2D> ();
		initPosition = gameObject.transform.position;
	}

	void Update () {
		currentPosition = initPosition;
		if (direction == 1)
			currentPosition.x = initPosition.x + Mathf.Sin (Time.timeSinceLevelLoad)*times;
		else if (direction == 2)
			currentPosition.y = initPosition.y + Mathf.Sin (Time.timeSinceLevelLoad)*times;
		rigidBody.MovePosition (currentPosition);
	}
}
