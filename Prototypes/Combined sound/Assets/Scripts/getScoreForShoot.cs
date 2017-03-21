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
    public Text count;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        scoreCount = GameObject.FindGameObjectWithTag("scoreCount").GetComponent<Text>();
        winText = GameObject.FindGameObjectWithTag("winText").GetComponent<Text>();
        finishText = GameObject.FindGameObjectWithTag("finishText").GetComponent<Text>(); 
        count = finishText = GameObject.FindGameObjectWithTag("finishText").GetComponent<Text>();
        SetCountText();
        winText.text = "";
        finishText.text = "";
    }


    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Enemy") //shootin a microbe or parasite
        {
            other.gameObject.SetActive(false);
            int value = int.Parse(count.text) + 10;
            count.text = value.ToString();
            //int anInteger;
            //anInteger = Convert.ToInt32(textBox1.Text);
            //anInteger = int.Parse(textBox1.Text);
            SetCountText();
        }

        else if (other.gameObject.CompareTag("Useful")) //shooting red or white blood cells by mistake
        {
            other.gameObject.SetActive(false);
            int value = int.Parse(count.text) - 5;
            count.text = value.ToString();
        }

    }

    void SetCountText()
    {
        scoreCount.text = "Score: " + count.ToString();
        
    }
}

