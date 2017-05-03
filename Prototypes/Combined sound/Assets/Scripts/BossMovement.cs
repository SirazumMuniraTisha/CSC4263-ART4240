using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossMovement : MonoBehaviour {
    SpriteRenderer Boss;
    Sprite StillBoss;
    public Sprite MovingBoss;
    Rigidbody2D rigidBody;
    Vector2 currentPosition;
    Vector2 initialPosition;
    int count = 0;
    float scale = 8.0f;
    float time =0;
    public AudioSource Win;
	public Sprite BossDead;
	Text currentScoreText;
	public string scenechange;
    void Start()
    {
		currentScoreText = GameObject.FindGameObjectWithTag("scoreCount").GetComponent<Text>(); 
		currentScoreText.text = count.ToString();
        Boss = (SpriteRenderer)GetComponent("SpriteRenderer");
        StillBoss= Boss.sprite;
        rigidBody = gameObject.GetComponent<Rigidbody2D>();
        initialPosition = gameObject.transform.position;
    }


    void Update()
    {
		if (count < 10) {
			currentPosition = initialPosition;
			currentPosition.x = initialPosition.x + Mathf.Sin (Time.timeSinceLevelLoad);
			if (currentPosition.x < initialPosition.x) {
				Boss.sprite = MovingBoss;
				//gameObject.transform.localScale = new Vector2 (scale * 1.5f, scale);
			} else {
				Boss.sprite = StillBoss;
				//gameObject.transform.localScale = new Vector2 (1.5f, 1.0f);
			}
			currentPosition.y = initialPosition.y + Mathf.Sin (Time.timeSinceLevelLoad);
			rigidBody.MovePosition (currentPosition);
		}
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "bullet")
        {
            count += 1;
            if (count == 10)
            {
                
				Boss.sprite = BossDead;
				//gameObject.SetActive(false);
				PlayerPrefs.SetString ("s", currentScoreText.text);
                Win.Play();
                Invoke("KillBoss", 2);   
            }
        }
    }
    void KillBoss()
    {
		Application.LoadLevel(scenechange);
    }
}

