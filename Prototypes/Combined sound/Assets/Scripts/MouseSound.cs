using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MouseSound : MonoBehaviour {
	public AudioSource MouseEnter;
	public AudioSource MouseDown;

	//public AudioClip Sound;
	void Start()
	{
		GetComponent<AudioSource>();
	}
	void Update()
	{
		
	}
	void OnMouseEnter(){
		MouseEnter.Play();
	}
	void OnMouseDown(){
		MouseDown.Play();
	}


}
