using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class getScoreForShoot : MonoBehaviour
{
    Rigidbody2D rb;
    private int count;
    public Text scoreCount;
    public Text winText;
    public Text finishText;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        scoreCount = GameObject.FindGameObjectWithTag("scoreCount").GetComponent<Text>();
        winText = GameObject.FindGameObjectWithTag("winText").GetComponent<Text>();
        finishText = GameObject.FindGameObjectWithTag("finishText").GetComponent<Text>();
        count = 0;
        SetCountText();
        winText.text = "";
        finishText.text = "";
    }


    void OnTriggerEnter2D(Collider2D other)
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
        
    }
}

