using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
 * code to respawn enemies
 */
public class SpawnScript : MonoBehaviour {

	public GameObject enemy; //enemy prefab to be spawned
	public float spawnTime = 9f; //time between spawns
	public Transform [] spawnPoint;

	void Start()
	{
		//Call spzwn function every 2 seconds
		InvokeRepeating("Spawn", 12f, spawnTime);
	}

	void Spawn()
	{
		int spawnPointIndex = Random.Range (0, spawnPoint.Length);
		Instantiate (enemy, spawnPoint [spawnPointIndex].position, spawnPoint [spawnPointIndex].rotation);
	}
}
