using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
 * code to respawn enemies
 */
public class PowerUpSpawn: MonoBehaviour {

	public GameObject power; //enemy prefab to be spawned
	public float spawnTime = 30f; //time between spawns
	public Transform [] spawnPoint;

	void Start()
	{
		//Call spzwn function every 15 seconds
		InvokeRepeating("Spawn", 15f, spawnTime);
	}

	void Spawn()
	{
		int spawnPointIndex = Random.Range (0, spawnPoint.Length);
		Instantiate (power, spawnPoint [spawnPointIndex].position, spawnPoint [spawnPointIndex].rotation);
	}

}
