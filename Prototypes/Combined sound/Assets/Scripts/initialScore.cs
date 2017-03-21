using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class initialScore : MonoBehaviour
{

    Rigidbody2D rb;
    private int count;
    public Text currentScoreText;
    public Text winText;

    void Start()
    {
        currentScoreText = GetComponent<Text>();
        winText = GameObject.FindGameObjectWithTag("winText").GetComponent<Text>();
        winText.gameObject.SetActive(false);
        count = 0;
        //SetCountText();
        currentScoreText.text = "Score: " + count.ToString();
    }

    
}
