using UnityEngine;
using System.Collections;

public class scoreScript : MonoBehaviour {


	private UnityEngine.UI.Text scoreText;
	// Use this for initialization

	void Awake () {
		scoreText = GetComponent<UnityEngine.UI.Text> ();
	}

	void Start () {
	 	
	}
	
	// Update is called once per frame
	void Update () {
		scoreText.text = "Score: " + bulletScript.currentScore;
	}
}
