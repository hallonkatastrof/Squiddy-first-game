using UnityEngine;
using System.Collections;

public class enemyAI : MonoBehaviour {

	public float enemySpeed = 1f; 
	public bool touchRightWall = false;
	public bool touchLeftWall = false;
	public int playerDead = 0;

	private UnityEngine.UI.Text levelText;

	private bool goingLeft = false;
	private bool goingRight = false;

	// Use this for initialization
	void Awake () {
		
	}
	
	// Update is called once per frame
	void Update () { 
		if (goingLeft == true) {
			transform.position += Vector3.left * Time.deltaTime * enemySpeed; 	
		} else if (goingRight == true) {
			transform.position += Vector3.right * Time.deltaTime * enemySpeed; 
		} else {
			transform.position += Vector3.right * Time.deltaTime * enemySpeed;
		}

		if (playerDead >= 1) {
			levelText.text = "Game Over";

		}

		levelText = GetComponent<UnityEngine.UI.Text> ();
	}
	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.tag == "RightWall") {
			goingLeft = true;
			goingRight = false;
			Debug.Log ("Touched right wall");
		} else if (col.gameObject.tag == "LeftWall") {
	
			goingRight = true;
			goingLeft = false;
			Debug.Log ("Touched left wall");
		} 

		if (col.gameObject.tag == "Enemy" && !goingRight) {
			goingRight = true;
			goingLeft = false;
			Debug.Log ("touched enemy!");
		} else if (col.gameObject.tag == "Enemy" && !goingLeft) {
			goingRight = false;
			goingLeft = true;
		} 

		if (col.gameObject.tag == "Player") {
			Destroy (col.gameObject);
			playerDead = 1;
		} 
	}


}
