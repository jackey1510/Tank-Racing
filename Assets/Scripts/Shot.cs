using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour {

	public float speed;
	public float slow = 0.3f;
	public float targetNumber;
	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody2D> ().velocity = transform.up * speed;
	}
	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == string.Format("Player{0}",targetNumber)) {
			Debug.Log ("hit");
			other.GetComponent<Rigidbody2D>().velocity = other.GetComponent<Rigidbody2D>().velocity*slow; 
			Destroy (gameObject);
		}
	}
}
