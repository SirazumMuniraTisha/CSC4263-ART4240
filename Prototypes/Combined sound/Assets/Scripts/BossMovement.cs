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
    float scale = 8.0f;
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
        {
            Boss.sprite = MovingBoss;
            gameObject.transform.localScale = new Vector2(scale*1.5f, scale);
        }
        else
        {
            Boss.sprite = StillBoss;
            gameObject.transform.localScale = new Vector2(1.5f, 1.0f);
        }
            currentPosition.y = initialPosition.y + Mathf.Sin( Time.timeSinceLevelLoad);
        rigidBody.MovePosition(currentPosition);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "bullet")
        {
            count += 1;
            if(count ==10)
            Destroy(gameObject);
        }
    }
}
