using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class getScoreForShoot : MonoBehaviour
{
    public Text scoreCount;
    public Text winText;
    public Text finishText;
    public static int count = 0;

    void Start()
    {
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
	void Update(){

	}
    void SetCountText()
    {
        scoreCount.text = count.ToString();
        
        //if(count >= 30)
        //{
            //print(count);
          //  winText.text = "Congratulations! You Win.";
            //winText.gameObject.SetActive(true);
        //}
        
    }


}

