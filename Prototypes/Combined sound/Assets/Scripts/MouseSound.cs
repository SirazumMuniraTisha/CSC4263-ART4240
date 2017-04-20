using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MouseSound : MonoBehaviour {
	public AudioClip Sound;
	public AudioSource Source;
	void Start()
	{
		Source = GetComponent<AudioSource>();
	}
	void OnMouseEnter(){
		Debug.Log ("Play_Audio");
		Source.PlayOneShot (Sound);
	}
}
