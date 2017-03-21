using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class initialScore : MonoBehaviour
{

    Rigidbody2D rb;
    private int count;
    private int immunityPercentage;
    public Text currentScoreText;
    public Text currentImmunityText;

    void Start()
    {
        currentScoreText = GameObject.FindGameObjectWithTag("scoreCount").GetComponent<Text>(); ;
        currentImmunityText = GameObject.FindGameObjectWithTag("immunity").GetComponent<Text>(); ;
        count = 0;
        immunityPercentage = 100;


        currentScoreText.text = "Score: " + count.ToString();
        currentImmunityText.text = "Immunity Level: " + immunityPercentage.ToString() + "%";
    }

    
}
