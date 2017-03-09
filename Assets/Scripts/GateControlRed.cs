using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateControlRed : MonoBehaviour
{
	public float gateNumber;
    void OnTriggerEnter2D(Collider2D coll)
    {
		if (coll.tag== "shot2") {
			Destroy(GameObject.FindWithTag(string.Format("RedGate{0}",gateNumber)));
            Destroy(coll.gameObject);
        }
		if (coll.tag == "shot1") {
			Destroy(coll.gameObject);
		}
    }
}
