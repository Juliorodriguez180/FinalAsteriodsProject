using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorOnCollision : MonoBehaviour {

	private SpriteRenderer sr;
	private Rigidbody2D rb;
	public float targetValue = 0.0f;

	// Use this for initialization
	void Start () {
		sr = GetComponent<SpriteRenderer> ();
		rb = GetComponent<Rigidbody2D> ();
	}

	// Update is called once per frame
	void Update () {

	}

	void OnCollisionEnter2D (Collision2D collision) {

		if (collision.relativeVelocity.magnitude > targetValue) {
			sr.color = Color.red;
		} else {
			Debug.Log (collision.relativeVelocity.magnitude);
		}

	}

	void OnCollisionExit2D () {
		sr.color = Color.green;
	}

	void OnCollisionStay2D() {
		Debug.Log ("Ouch!");
	}


}

