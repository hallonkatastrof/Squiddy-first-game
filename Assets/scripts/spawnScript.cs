using UnityEngine;
using System.Collections;

public class spawnScript : MonoBehaviour 
{   
	public GameObject enemy;                // The enemy prefab to be spawned.
	public float spawnTime = 0f;            // How long between each spawn.
	public Transform[] spawnPoints;         // An array of the spawn points this enemy can spawn from.
	private Vector2 spawnPosition;
	public GameObject[] objects;


	void Start ()
	{
		// Call the Spawn function after a delay of the spawnTime and then continue to call after the same amount of time.
	
	}

	void Spawn() 
	{
		spawnPosition.x = Random.Range (-6.44f, 6.12f);
		spawnPosition.y = Random.Range (7.76f, 7.57f);
		Instantiate (objects[UnityEngine.Random.Range(0, objects.Length)], spawnPosition, Quaternion.identity);
	}

	void OnCollisionEnter2D (Collision2D col) 
	{
		if (col.gameObject.tag == "Player") 
			{
			Spawn ();
			Destroy (col.gameObject);
			}
			
	}
	void Update () 
	{
		objects = GameObject.FindGameObjectsWithTag ("Player");
	}
}