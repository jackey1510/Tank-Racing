using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gate_blue : MonoBehaviour {

    public float slow = 0.1f;
    void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "Player1")
        {
            other.GetComponent<Rigidbody2D>().velocity = other.GetComponent<Rigidbody2D>().velocity * slow;
        }
    }
}
