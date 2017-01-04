using UnityEngine;
using System.Collections;

public class bulletScript : MonoBehaviour {

	public float bulletSpeed = 100;
	private Vector2 mousePos;
	private Vector3 playerPos;
	public Transform bullet;
	public static int currentScore;



	// Use this for initialization


	// Update is called once per frame
	void Update () {

		if (mousePos.x > playerPos.x) {
			transform.position += Vector3.right * Time.deltaTime * bulletSpeed;
		} 

		if (mousePos.x < playerPos.x)
		{
			transform.position += Vector3.left * Time.deltaTime * bulletSpeed;
		}

		mousePos = Camera.main.ScreenToWorldPoint(new Vector2(Input.mousePosition.x, Input.mousePosition.y));
		playerPos = GameObject.Find ("squiddy").transform.position;
	}
	void OnCollisionEnter2D (Collision2D col) 
	{
	if (col.gameObject.tag == "Enemy") {
		Destroy (col.gameObject);
			Destroy (bullet);
			currentScore += 1;

	}
		if (col.gameObject.tag == "RightWall") 
		{
			Destroy (bullet);
		} else if (col.gameObject.tag == "LeftWall") 
		{
			Destroy (bullet);
		}
}
}
