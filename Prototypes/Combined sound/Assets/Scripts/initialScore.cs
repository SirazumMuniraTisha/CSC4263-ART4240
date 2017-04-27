using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class initialScore : MonoBehaviour
{
    private int count;
	GameObject player;
    private int immunityPercentage;
    Text currentScoreText;
    //public Text currentImmunityText;
    void Start()
    {
        currentScoreText = GameObject.FindGameObjectWithTag("scoreCount").GetComponent<Text>(); 
        //currentImmunityText = GameObject.FindGameObjectWithTag("immunity").GetComponent<Text>(); 
        count = 0;
        immunityPercentage = 100;
		currentScoreText.text = count.ToString();
       // currentImmunityText.text = "Immunity Level: " + immunityPercentage.ToString() + "%";

    }
	void Update(){
		PlayerPrefs.SetString ("s", currentScoreText.text);
		player = GameObject.FindGameObjectWithTag ("Player");
		if (player==null)
			Application.LoadLevel ("GameOver");
	}
    
}
