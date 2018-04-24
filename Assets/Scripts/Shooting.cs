using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour {
	public GameObject bulletPrefab;
	public Transform shootPoint;
	public float BulletSpeed; 

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//This if statement is saying if the Space Key is being pressed down, bullets will fire from the ship 
		if (Input.GetKeyDown(KeyCode.Space)){
			GameObject InstantiateBullet; 
			InstantiateBullet = Instantiate (bulletPrefab, shootPoint.position, shootPoint.rotation);	
			InstantiateBullet.GetComponent<Rigidbody2D> ().AddForce (transform.right * 	BulletSpeed);

	}
}	
}
