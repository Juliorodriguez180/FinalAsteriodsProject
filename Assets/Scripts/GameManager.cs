using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
	public static GameManager instance; 
	public int score = 0;
	public List <GameObject> EnemiesInGame; 
	public GameObject Player; 
	public int PlayerLife; 
	public Text LifeCounter; 
	[HideInInspector]
	public bool DeathByEnemy;

	void Awake () {
		// As long as there is not an instance already set
		if (instance == null) {
			instance = this; // Store THIS instance of the class (component) in the instance variable
			DontDestroyOnLoad (gameObject); // Don't delete this object if we load a new scene
		} else {
			Destroy (this.gameObject); // There can only be one - this new object must die
			Debug.Log ("Warning: A second game manager was detected and destroyed.");
			GameManager.instance.score += 100;
		}
	}
	void Update(){
		//Life Counter for the player 
		LifeCounter.text = "Lifes: " + PlayerLife;
		if (PlayerLife <= 0) {
			Application.Quit();
		}
		if (Player.activeSelf == false) {
			//Foreach Gameobject for enemies in game, we are going to do something 
			foreach (GameObject Enemies in EnemiesInGame) {
				Destroy (Enemies);
				EnemiesInGame.Remove (Enemies);
			}
			//This is for the player to respawn after dieing 
			if (Input.GetKeyDown (KeyCode.Space)) {
				DeathByEnemy = false; 
				Player.transform.position = Vector3.zero;
				Player.SetActive (true);

			}
		}
	}	
}