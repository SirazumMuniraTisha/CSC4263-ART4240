using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
 * code to respawn enemies
 */
public class SpawnScript : MonoBehaviour {

	public GameObject enemy; //enemy prefab to be spawned
	public float spawnTime = 9f; //time between spawns
    public float spawnRate = 9f; //time between spawns
    public Transform [] spawnPoint;
    private float timer;

	void Start()
	{
		//Call spzwn function every 2 seconds
		InvokeRepeating("Spawn", 5f, spawnTime);
        timer = Time.time + 3;
	}

	void Spawn()
	{
        if (timer < Time.time)
        {
            int spawnPointIndex = Random.Range(0, spawnPoint.Length);
            Instantiate(enemy, spawnPoint[spawnPointIndex].position, spawnPoint[spawnPointIndex].rotation);
            timer = Time.time + 3;
        }
	}
}
