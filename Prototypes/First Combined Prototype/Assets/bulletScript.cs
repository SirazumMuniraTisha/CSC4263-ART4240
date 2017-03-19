using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletScript : MonoBehaviour {
	public GameObject bullet;
	public Transform firePoint;


	Rigidbody2D r2d;
	private void Start()
	{
		r2d = GetComponent<Rigidbody2D>();

	}
	// Update is called once per frame
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Return))
		{
			Instantiate(bullet, firePoint.position, firePoint.rotation);
		}
	}


}
