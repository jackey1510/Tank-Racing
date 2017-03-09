using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gate_red : MonoBehaviour
{

    public float slow = 0.8f;
    void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "Player2")
        {
            other.GetComponent<Rigidbody2D>().velocity = other.GetComponent<Rigidbody2D>().velocity * slow;
        }
    }
}


