using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour {
    public GameObject enemy; //enemy prefab to be spawned
    public Transform spawnPoint;
    public Transform spawnPoint1;
    public Transform spawnPoint2;
    public Transform spawnPoint3;
    public Transform spawnPoint4;
    public Transform spawnPoint5;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("working");
        if (other.gameObject.tag == "T1")
        {
            Instantiate(enemy, spawnPoint.position, spawnPoint.rotation);
            Instantiate(enemy, spawnPoint1.position, spawnPoint1.rotation);
        }
        else if (other.gameObject.tag == "T2")
        {
            Instantiate(enemy, spawnPoint2.position, spawnPoint.rotation);
            Instantiate(enemy, spawnPoint3.position, spawnPoint1.rotation);
            Instantiate(enemy, spawnPoint4.position, spawnPoint.rotation);
            Instantiate(enemy, spawnPoint5.position, spawnPoint1.rotation);
        }
    }
}
