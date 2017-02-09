using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour {


    // Spawn 
	public GameObject avgJoe; // the average joe
   // public GameObject wizardJoe; // Wizard joe
    public GameObject hipsterJoe; // hipster joe
    public GameObject skateJoe; // skatejoe
	public float spawnTime = 3f; // time to wait before spawning
	public Transform[] spawnPoints;	// An array of the spawn points this enemy can spawn from.
	private int joeCounter = 0;
	private int joeMax;
   
	private float InstantiationTimer = 2f;

    // Working with the day system in GameController
    private GameObject GO;
    private GameController GC;
    // Spawn Joe
    void Spawn()
	{
		// Find a random index between zero and one less than number of spawn points.
		int spawnPointIndex = Random.Range(0, spawnPoints.Length);

        // Create an instance of the enemy prefab at the randomly selected spawn point's position and rotation.

        int r = Random.Range(0,2);
        if(r == 0 )
            Instantiate(avgJoe, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
        /*if(r == 1)
            Instantiate(wizardJoe, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
     */    
    if (r == 1)
            Instantiate(hipsterJoe, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
        if (r == 2)
            Instantiate(skateJoe, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);

        joeCounter++;
		//if (joeCounter >= joeMax)
			//stopSpawning(
	}

    void stopSpawning()
    {
        // 
        CancelInvoke("Spawn");
    }

	// Use this for initialization
	void Start () {

        // Find gameobject with tag GameController
        GO = GameObject.FindGameObjectWithTag("GameController");
        GC = GO.GetComponent<GameController>();
		/*
		InstantiationTimer -= Time.deltaTime;
		if (InstantiationTimer <= 0) {
		
			Instantiate (avgJoe, new Vector3 (-2, 0, -6), Quaternion.identity);
			InstantiationTimer = 2f;
		}
*/
        if (GC.day == 0) {
            joeMax = 5;

        }
        if (GC.day == 1)
        {
			joeMax = 8;
			// Call the spawn after a delay of the spawnTime and then continue to call after the same amount of time.
			InvokeRepeating("Spawn", spawnTime,spawnTime);
            
        }
        if (GC.day == 2)
        {
			joeMax = 11;
			// Call the spawn after a delay of the spawnTime and then continue to call after the same amount of time.
			InvokeRepeating("Spawn", spawnTime,spawnTime);
           
        }
        if (GC.day == 3)
        {
			joeMax = 14;
			// Call the spawn after a delay of the spawnTime and then continue to call after the same amount of time.
			InvokeRepeating("Spawn", spawnTime,spawnTime);
            
        }
        if (GC.day == 4)
        {
			joeMax = 20;
			// Call the spawn after a delay of the spawnTime and then continue to call after the same amount of time.
			InvokeRepeating("Spawn", spawnTime,spawnTime);
            
        }
		if (GC.day >= 5) {
			joeMax++;
			// Call the spawn after a delay of the spawnTime and then continue to call after the same amount of time.
			InvokeRepeating("Spawn", spawnTime,spawnTime);

		}

        // Call the spawn after a delay of the spawnTime and then continue to call after the same amount of time.
        InvokeRepeating("Spawn", spawnTime,spawnTime);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
