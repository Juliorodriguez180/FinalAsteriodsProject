using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {
	//We are setting the bullet to destory the enemie when the bullet collideds with the enemie 
	public void OnTriggerEnter2D (Collider2D otherCollider){
		if (otherCollider.gameObject.CompareTag ("Enemy")) {
			Destroy (otherCollider.gameObject);
			Destroy (this.gameObject);
			GameManager.instance.EnemiesInGame.Remove (otherCollider.gameObject);
		}

	}
	//Here we are destoryin
	void Update(){
		Destroy (this.gameObject, 5.0f);
	}
}
