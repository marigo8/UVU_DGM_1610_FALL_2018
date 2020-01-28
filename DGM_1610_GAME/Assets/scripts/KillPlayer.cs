using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayer : MonoBehaviour {

	private LevelManager LevelManager;
	public int Damage;

	// Use this for initialization
	void Start () {
		LevelManager = FindObjectOfType <LevelManager>();
	}
	
	// Update is called once per frame
	void OnTriggerEnter2D (Collider2D other) {
		
		if(!Pause.Paused){
			if(other.name == "PC"){
				// LevelManager.RespawnPlayer();
				if(HealthManager.TakeDamage(Damage)){
					print("Attacking player");
				}
			}
		}
	}
}
