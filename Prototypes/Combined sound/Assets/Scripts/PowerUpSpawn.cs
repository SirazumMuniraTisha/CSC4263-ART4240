using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
 * code to respawn enemies
 */
public class PowerUpSpawn: MonoBehaviour {

	public GameObject power; //enemy prefab to be spawned
	private float spawnTime = 20f; //time between spawns
	public Transform [] spawnPoint;
    private float timer;

    void Start()
	{
		//Call spzwn function every 15 seconds
		InvokeRepeating("Spawn", 3f, spawnTime);
        timer = Time.time + 5;
    }

	void Spawn() {

        if (timer < Time.time)
        {
            int spawnPointIndex = Random.Range(0, spawnPoint.Length);
            Instantiate(power, spawnPoint[spawnPointIndex].position, spawnPoint[spawnPointIndex].rotation);
            timer = Time.time + 5;
        }
        }

}
