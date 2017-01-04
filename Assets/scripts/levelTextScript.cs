using UnityEngine;
using System.Collections;

public class levelTextScript : MonoBehaviour {

	private UnityEngine.UI.Text levelText;
	public float counter = 3;
	public GameObject restartButton;
	// Use this for initialization
	void Awake () {
		levelText = GetComponent<UnityEngine.UI.Text> ();
		counter -= Time.deltaTime;
		restartButton.gameObject.SetActive (false);
	}
		
	// Update is called once per frame
	void Update () {
		


	}
		//if (enemySpawn.currentLevel == 1 && counter >= 0) {
		//	InvokeRepeating("blinkingText", 0f, 2f);
		//} else {
		//	levelText.text = "";

		//}

	//void blinkingText() {
	//	levelText.text = "Harder!";
	//}
}

