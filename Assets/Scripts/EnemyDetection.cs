using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDetection : MonoBehaviour {

	public Transform targetTf;
	public float speed; 
	private Transform tf;
	public bool isAlwaysSeeking;
	private Vector3 movementVector;
	public bool isDirectional; 
	void Awake(){
		targetTf = GameManager.instance.Player.transform;  
	}	
	// Use this for initialization 
	void Start () {
		tf = GetComponent<Transform> ();
		// Target the Player
		movementVector = targetTf.position - tf.position;

	}
	
	// Update is called once per frame
	void Update () {
		if (isAlwaysSeeking){
		movementVector = targetTf.position - tf.position; //end postion - start position 
		}
		//Move Every Framedraw
		movementVector.Normalize(); //make length of 1 
		movementVector = movementVector * speed; //make length of 'speed'
		tf.position = tf.position + movementVector; //move down vector

		//if we need to look at the player
		if (isDirectional) {
			tf.right = movementVector;
		}
			}
	void OnTriggerEnter2D (Collider2D Other){
		//If enemie ship crashes into Player, player will lose a life 
		if (Other.gameObject.CompareTag ("Player")) {
			GameManager.instance.DeathByEnemy = true;
			GameManager.instance.PlayerLife -= 1; 
			Other.gameObject.SetActive (false);
			Destroy (this.gameObject);
			GameManager.instance.EnemiesInGame.Remove (this.gameObject);
		}
	}
	}


