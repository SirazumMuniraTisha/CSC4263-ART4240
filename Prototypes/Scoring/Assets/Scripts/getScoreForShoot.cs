using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class getScoreForShoot : MonoBehaviour
{
    Rigidbody2D rb;
    private int count;
    public Text countText;
    public Text winText;
    public Text finishText;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        count = 0;
        SetCountText();
        winText.text = "";
        finishText.text = "";
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag.Contains("BA") || other.gameObject.CompareTag("PS")) //shootin a microbe or parasite
        {
            other.gameObject.SetActive(false);
            count = count + 10;
            SetCountText();
        }

        else if (other.gameObject.CompareTag("WBC")) //shooting white blood cell by mistake
        {
            other.gameObject.SetActive(false);
            count = count - 5;
            SetCountText();
        }

    }

    void SetCountText()
    {
        countText.text = "Score: " + count.ToString();
        if (count >= 5)
        {
            winText.text = "Congratulations! You Win";
            rb.gameObject.SetActive(false);
        }
    }
}

