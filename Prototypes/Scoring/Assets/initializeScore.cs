using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class initializeScore : MonoBehaviour {

    Rigidbody2D rb;
    private int count;
    public Text currentScoreText;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        count = 0;
        SetCountText();
    }

    void SetCountText()
    {
        currentScoreText.text = "Score: " + count.ToString();
        
    }
}
