﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitBox : MonoBehaviour {

	//This Script is to set the limits of the game area for both the player and the enemies, to where if they leave the playable area, they will be killed

	void OnTriggerExit2D(Collider2D other){
		if (other.gameObject.CompareTag("Player")){
			if (GameManager.instance.DeathByEnemy == false) {
				GameManager.instance.Player.SetActive (false);
				GameManager.instance.PlayerLife -= 1; 
			}
		
		}
			else {
			if (other.gameObject.CompareTag("Enemie")){
				GameManager.instance.EnemiesInGame.Remove (other.gameObject);
			}	
			Destroy(other.gameObject);
				
			}
	}

}
