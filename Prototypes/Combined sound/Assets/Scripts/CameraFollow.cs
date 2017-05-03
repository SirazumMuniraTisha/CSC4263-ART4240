using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public GameObject player;
    public float speed = 12.0f;
    int score;
    void Start()
    {

    }
    void Update()
    {
        if (player != null)
        {
            float xPos = Mathf.Lerp(transform.position.x, player.transform.position.x, speed * Time.deltaTime);
            transform.position = new Vector3(xPos, 0, -10);
        }
    }
}
