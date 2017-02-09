using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour {

	public GameObject joe; // the joe prefab
	public float spawnTime = 3f; // time to wait before spawning
	public Transform[] spawnPoints;	// An array of the spawn points this enemy can spawn from.
	private int joeCounter = 0;
	private int joeMax = 7;

	// Spawn Joe
	void Spawn()
	{
		// Find a random index between zero and one less than number of spawn points.
		int spawnPointIndex = Random.Range(0, spawnPoints.Length);

		// Create an instance of the enemy prefab at the randomly selected spawn point's position and rotation.
		Instantiate(joe, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
		joeCounter++;
		if (joeCounter >= joeMax)
			CancelInvoke ("Spawn");
	}

	// Use this for initialization
	void Start () {

		// Call the spawn after a delay of the spawnTime and then continue to call after the same amount of time.
		InvokeRepeating("Spawn", spawnTime,spawnTime);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
