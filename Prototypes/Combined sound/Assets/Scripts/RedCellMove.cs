using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedCellMove : MonoBehaviour {

    float amplitudeX = 10.0f;
    float amplitudeY = 6.0f;
    float omegaX = 1.0f;
    float omegaY = 5.0f;
    public float index;
    public float speed;
    Rigidbody2D rigidbody2d;

    void Awake()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        rigidbody2d.velocity = new Vector2(speed , 0f);
    }
    public void Update()
    {
        index+=Time.deltaTime;
        float x = -amplitudeX * index;
        float y = (amplitudeY * Mathf.Sin(omegaY + index));
        rigidbody2d.transform.position = new Vector2(x, y);
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("boundary"))
        {
            rigidbody2d.gameObject.SetActive(false);
        }

    }
}
