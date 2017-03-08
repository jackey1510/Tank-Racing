using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateControlRed : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D coll)
    {
		if (coll.tag== "shot2") {
            Destroy(GameObject.FindWithTag("RedGate1"));
            Destroy(coll.gameObject);
        }
        
    }
}
