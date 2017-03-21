using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class getScoreForShoot : MonoBehaviour
{
    Rigidbody2D rb;
    public Text scoreCount;
    public Text winText;
    public Text finishText;
    public static int count = 0;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        scoreCount = GameObject.FindGameObjectWithTag("scoreCount").GetComponent<Text>();
        winText = GameObject.FindGameObjectWithTag("winText").GetComponent<Text>();
        finishText = GameObject.FindGameObjectWithTag("finishText").GetComponent<Text>();
        SetCountText();
        winText.text = "";
        finishText.text = "";
    }


    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Enemy") //shootin a microbe or parasite
        {
            other.gameObject.SetActive(false);
            count = count + 10;
            SetCountText();
        }

        else if (other.gameObject.CompareTag("Useful")) //shooting red or white blood cells by mistake
        {
            other.gameObject.SetActive(false);
            count = count - 5;
            SetCountText();

        }

    }

    void SetCountText()
    {
        scoreCount.text = "Score: " + count.ToString();
        
        if(count >= 20)
        {
            print(count);
            //Vector2 initPosition = winText.transform.position;
            //Vector2 currentPosition;
            //currentPosition.y = initPosition.y - 600.0f;
            //winText.transform.Translate(0, 0, 0);
            winText.gameObject.SetActive(true);
        }
        
    }


}

