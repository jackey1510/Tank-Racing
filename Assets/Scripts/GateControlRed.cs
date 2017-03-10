using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateControlRed : MonoBehaviour
{
	public float gateNumber;
	public GameObject redGate;
	public bool gateOn = true;
	//public GameObject blueGate;
	//private Vector3 scale;
    void OnTriggerEnter2D(Collider2D coll)
    {
		
		if (gateOn == true) {
			if (coll.tag == "shot1") {
				redGate.transform.position += Vector3.up*100f;
				gateOn = false;
				Destroy (coll.gameObject);


			}
			if (coll.tag == "shot2") {
				Destroy (coll.gameObject);
			}
		} else {
			if (coll.tag == "shot2") {
				redGate.transform.position -= Vector3.up*100f;
				gateOn = true;
				Destroy (coll.gameObject);
			}
			if (coll.tag == "shot1") {
				Destroy (coll.gameObject);
			}
		}
    }
}
