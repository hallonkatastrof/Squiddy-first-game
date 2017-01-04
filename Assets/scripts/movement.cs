using UnityEngine;
using System.Collections;

public class movement : MonoBehaviour {

	public float speed = 1f; 
	public float jumpPower = 1f;
	public bool grounded = true;

	public Transform bullet;
	private Vector2 mousePos;
	private Vector3 playerPos;
	public bool shotsFired = false;
	public float shotTimer = 2f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		mousePos = Camera.main.ScreenToWorldPoint(new Vector2(Input.mousePosition.x, Input.mousePosition.y));
		playerPos = GameObject.FindGameObjectWithTag ("Player").transform.position;

		var move = new Vector3(Input.GetAxis ("Horizontal"), 0);
		transform.position += move * speed * Time.smoothDeltaTime; 
		if(!grounded && GetComponent<Rigidbody2D>().velocity.y <= 0) {
			grounded = true;
		}
		if (Input.GetButtonDown("Jump") && grounded == true) {
			GetComponent<Rigidbody2D>().AddForce(transform.up*jumpPower);
			grounded = false;
		}
		if (Input.GetMouseButtonDown(0) && shotsFired == false && shotTimer <= 0) {
			Instantiate (bullet, playerPos, Quaternion.identity);
			shotsFired = false;
			shotTimer = 2f;
		}

		shotTimer -= Time.deltaTime;

	}


}
