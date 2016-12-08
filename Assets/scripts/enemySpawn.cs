using UnityEngine;
using System.Collections;

public class enemySpawn : MonoBehaviour {


	private Vector2 spawnPosition;
	public Transform prefab;
	public float timer = 2.5f;
	public int maxEnemies;
	public bool hasSpawned = true;
	public float enemySpeed = 1f; 
	private GameObject[] enemies;



	// Use this for initialization
	void Start () 
	{

	}

	void Spawn() //the spawn function
	{
		if (!hasSpawned) { //run if hasSpawned = true
			Instantiate (prefab, new Vector2 (Random.Range (-6, 6), Random.Range (6, 6)), Quaternion.identity); //Create clone of prefab, as defined above.
			Debug.Log ("New Enemy Has Arrived");
			hasSpawned = true;
		} else {
			hasSpawned = false;
		}
	}

	// Update is called once per frame
	void Update ()
	{
		timer -= Time.deltaTime;
		if (timer <= 0f && enemies.Length < 10) {
			Spawn ();
			timer = 2.5f; //interval between spawning in seconds. This is doubled due to hasSpawned.
		}
		enemies = GameObject.FindGameObjectsWithTag ("Enemy");
	}

}

