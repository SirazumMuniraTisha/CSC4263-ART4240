using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn2 : MonoBehaviour {
    public GameObject useful;
    public float spawnTime = 5f;
    private Vector2 spawnPoint;

    // Use this for initialization
    void Start () {
        // Call the 'addUse' function in 0 second
        // Then every 'spawnTime' seconds
        InvokeRepeating("addUse", 0, spawnTime);
    }
	
	// Update is called once per frame
	void addUse () {
         Renderer rd = GetComponent<Renderer>();
       float x1 = transform.position.y - rd.bounds.size.y/2;
        float x2 = transform.position.y + rd.bounds.size.y / 2;
         spawnPoint = new Vector2(Random.Range(x1, x2), transform.position.y);
        Instantiate(useful, spawnPoint, Quaternion.identity);

    }
}
