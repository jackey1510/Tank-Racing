using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateController : MonoBehaviour
{
	public float gateNumber;
	public GameObject redGate;
	//public GameObject blueGate;
	//public bool red = true;
	//private Vector3 scale;
	//private string tag;
	//private float gn = gateNumber;
	void OnTriggerEnter2D(Collider2D coll)
	{
		//scale = redGate.transform.localScale;
		//if (red == true) {
			if (coll.tag == "shot2") {
				//Destroy(GameObject.FindWithTag(string.Format("RedGate{0}",gateNumber)));
				//tag = redGate.tag;
				//Instantiate (blueGate, redGate.transform.position, redGate.transform.rotation);
				//blueGate.transform.localScale = scale;
				//blueGate.tag = tag;
				Destroy(GameObject.FindWithTag(string.Format("RedGate{0}",gateNumber)));
				Destroy (coll.gameObject);
				//red = false;
			}
			if (coll.tag == "shot1") {
				Destroy (coll.gameObject);
			}
//		} else {
//			if (coll.tag == "shot1") {
//				//Destroy(GameObject.FindWithTag(string.Format("RedGate{0}",gateNumber)));
//				//scale = blueGate.transform.localScale;
//				//tag = blueGate.tag;
//				Instantiate (redGate, blueGate.transform.position, blueGate.transform.rotation);
//				redGate.transform.localScale = scale;
//				redGate.tag = tag;
//				Destroy(GameObject.FindWithTag(string.Format("RedGate{0}",gateNumber)));
//				red =true;
//				Destroy (coll.gameObject);
//			}
//			if (coll.tag == "shot2") {
//				Destroy (coll.gameObject);
//			}
//		}
	}
}
