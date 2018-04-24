using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DugRandom : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log (Random.value); 
		Debug.Log (Random.Range(12.0f, 32.0f));
	}
}
