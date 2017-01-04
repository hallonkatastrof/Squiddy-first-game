using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class restartButtonScript : MonoBehaviour {

	// Use this for initialization
	void Update () {
		
	}
	
	public void restart () {
		SceneManager.LoadScene (SceneManager.GetActiveScene().name);
	}
}
