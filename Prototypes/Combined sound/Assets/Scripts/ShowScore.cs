using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowScore : MonoBehaviour {
	string score;
	public Text Score;
	// Use this for initialization
	void Start () {
		//scoreCount = GameObject.FindGameObjectWithTag("scoreCount").GetComponent<Text>();
		score = PlayerPrefs.GetString ("s", "default");
		Score.text = "Score: "+ score;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
