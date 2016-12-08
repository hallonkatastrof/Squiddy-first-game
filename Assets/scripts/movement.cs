using UnityEngine;
using System.Collections;

public class movement : MonoBehaviour {

	public float speed = 1f; 
	public float jumpPower = 1f;
	public bool grounded = true;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		var move = new Vector3(Input.GetAxis ("Horizontal"), 0);
		transform.position += move * speed * Time.smoothDeltaTime; 
		if(!grounded && GetComponent<Rigidbody2D>().velocity.y <= 0) {
			grounded = true;
		}
		if (Input.GetButtonDown("Jump") && grounded == true) {
			GetComponent<Rigidbody2D>().AddForce(transform.up*jumpPower);
			grounded = false;
		}
	}
}
