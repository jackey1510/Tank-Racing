using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour {

	public float acceleration = 0.2f;
	public float braking = 0.3f;
	public float steering = 4.0f;
	public bool canShoot = true;
	public GameObject shot;
	public Transform shotSpawn;
	public float fireRate = 0.5f;
	private float nextFire;
	PlayerInputs _inputs;



	// Use this for initialization
	void Start () {
		_inputs = GetComponent<PlayerInputs>();

	}

	void Update ()
	{
		if (canShoot == true) {
			if (_inputs.GetFireButton () && Time.time > nextFire) {
				nextFire = Time.time + fireRate;
				Instantiate (shot, shotSpawn.position, shotSpawn.rotation);
			}
		}
	}

	// update for physics
	void FixedUpdate() {
		// steering

		float s = steering;
		GetComponent<Rigidbody2D>().AddTorque(_inputs.x * s * -0.2f);
		float rot = transform.localEulerAngles.z - _inputs.x * s;
		transform.localEulerAngles = new Vector3(0.0f, 0.0f, rot);

		// acceleration/braking
		float velocity = GetComponent<Rigidbody2D>().velocity.magnitude;
		float y = _inputs.y;
		if (y > 0.01f) {
			velocity += y * acceleration;
		} else if (y < -0.01f) {
			velocity += y * braking;
		}

		// apply car movement
		GetComponent<Rigidbody2D>().AddForce(transform.up * _inputs.y * acceleration * 50.0f);

		GetComponent<Rigidbody2D>().velocity = transform.up * velocity;
		GetComponent<Rigidbody2D>().angularVelocity = 0.0f;
	}

}
