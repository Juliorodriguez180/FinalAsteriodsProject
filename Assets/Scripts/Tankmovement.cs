using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tankmovement : MonoBehaviour {

	public Transform tf;
	public float speed; 
	public float turnSpeed;

	// Use this for initialization
	void Start () {

		tf = GetComponent<Transform>();

	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey (KeyCode.W)) {
			tf.position += tf.right * speed;
			//tf.position += tf.TransformDirection(new Vector3(1,1,0)) * speed;
			//tf.Translate(Vector3.right, Space.Self);
		}

		if (Input.GetKey (KeyCode.D)) {
			tf.Rotate (0, 0, turnSpeed);
		}
		if (Input.GetKey (KeyCode.A)) {
			tf.Rotate (0, 0, -turnSpeed);
		}

	}
		
}
