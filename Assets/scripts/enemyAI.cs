using UnityEngine;
using System.Collections;

public class enemyAI : MonoBehaviour {

	public float enemySpeed = 1f; 
	public bool touchRightWall = false;
	public bool touchLeftWall = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () { 
		if (touchRightWall == true) {
			transform.position += Vector3.left * Time.deltaTime; 	
		} else if (touchLeftWall == true) {
			transform.position += Vector3.right * Time.deltaTime; 
		} else {
			transform.position += Vector3.right * Time.deltaTime;
		}
	}
	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.tag == "RightWall") {
			touchRightWall = true;
			touchLeftWall = false;
			Debug.Log ("Touched right wall");
		} else if (col.gameObject.tag == "LeftWall") {
			transform.position += Vector3.right * Time.deltaTime * enemySpeed; 
			touchLeftWall = true;
			touchRightWall = false;
			Debug.Log ("Touched left wall");
		}

		if (col.gameObject.tag == "Player") {
			Destroy (col.gameObject);
		} 
	}

}
