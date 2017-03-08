using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByContact : MonoBehaviour {
	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "Player1" || other.tag == "Player2" ){
			return;
		}
		Destroy (other.gameObject);

	}
}