using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutOfBounds : MonoBehaviour {

	public LevelManager LevelManager;

	// Use this for initialization
	void Start () {
		LevelManager = FindObjectOfType <LevelManager>();
	}
	
	// Update is called once per frame
	void OnTriggerEnter2D (Collider2D other) {
		
		if(!Pause.Paused){
			if(other.name == "PC"){
				LevelManager.RespawnPlayer();
			}
			else if(other.name != "GroundCheck"){
				print("Destroying "+other.name);
				Destroy(other.gameObject);
			}
		}
	}
}