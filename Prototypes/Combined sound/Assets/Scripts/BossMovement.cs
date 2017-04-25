using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMovement : MonoBehaviour {
    SpriteRenderer Boss;
    Sprite StillBoss;
    public Sprite MovingBoss;
    Rigidbody2D rigidBody;
    Vector2 currentPosition;
    Vector2 initialPosition;
    int count = 0;

    void Start()
    {
        Boss = (SpriteRenderer)GetComponent("SpriteRenderer");
        StillBoss= Boss.sprite;
        rigidBody = gameObject.GetComponent<Rigidbody2D>();
        initialPosition = gameObject.transform.position;
    }


    void Update()
    {
        currentPosition = initialPosition;
        currentPosition.x = initialPosition.x + Mathf.Sin(Time.timeSinceLevelLoad);
        if (currentPosition.x < initialPosition.x)
            Boss.sprite = MovingBoss;
        else
            Boss.sprite = StillBoss;
        currentPosition.y = initialPosition.y + Mathf.Sin( Time.timeSinceLevelLoad);
        rigidBody.MovePosition(currentPosition);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "bullet")
        {
            count += 1;
            if(count ==5)
            Destroy(gameObject);
        }
    }
}
