using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishTutorial2 : MonoBehaviour {

	private bool p1Arrive = false;
	private bool p2Arrive = false;
	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "Player1" ) {
			p1Arrive = true;
		}
		if (other.tag == "Player2" ) {
			p2Arrive = true;
		}
	}
	void Update(){
		if (p1Arrive == true && p2Arrive == true) {
			SceneManager.LoadScene("tutorial0.5",LoadSceneMode.Single);
		}
	}
}
