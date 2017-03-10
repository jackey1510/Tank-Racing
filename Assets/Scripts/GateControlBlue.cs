using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateControlBlue : MonoBehaviour
{
	public float gateNumber;
	public GameObject blueGate;
	public bool gateOn = true;
	void OnTriggerEnter2D(Collider2D coll)
	{

		if (gateOn == true) {
			if (coll.tag == "shot2") {
				blueGate.transform.position += Vector3.up*100f;
				gateOn = false;
				Destroy (coll.gameObject);
			}
			if (coll.tag == "shot1") {
				Destroy (coll.gameObject);
			}
		} else {
			if (coll.tag == "shot1") {
				blueGate.transform.position -= Vector3.up*100f;
				gateOn = true;
				Destroy (coll.gameObject);
			}
			if (coll.tag == "shot2") {
				Destroy (coll.gameObject);
			}
		}
	}
}
