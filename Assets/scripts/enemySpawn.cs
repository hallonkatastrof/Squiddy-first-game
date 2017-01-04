using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class enemySpawn : MonoBehaviour {


	private Vector2 spawnPosition;
	public Transform prefab;
	public float timer = 2.5f;
	public int maxEnemies;
	public bool hasSpawned = true;
	public float enemySpeed = 2f; 
	private GameObject[] enemies;
	public GUIText text;
	public int currentLevel;
	public UnityEngine.UI.Text levelText;


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
		if (timer <= 0f && bulletScript.currentScore >= 10) {
			Spawn ();
			timer = 1f; //interval between spawning in seconds. This is doubled due to hasSpawned.
			Debug.Log ("Higher Difficulty!");
			currentLevel += 1;
		} else if (timer <= 0f && enemies.Length < 10) {
			Spawn ();
			timer = 2.5f; //interval between spawning in seconds. This is doubled due to hasSpawned.
		} 

		if (currentLevel == 1) {
			levelText.text = "Harder!";
		} else {
			levelText.text = "";
		}

		enemies = GameObject.FindGameObjectsWithTag ("Enemy");
	}

}

