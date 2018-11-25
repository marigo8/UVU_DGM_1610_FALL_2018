using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayer : MonoBehaviour {

	public LevelManager LevelManager;

	// Use this for initialization
	void Start () {
		LevelManager = FindObjectOfType <LevelManager>();
	}
	
	// Update is called once per frame
	void OnTriggerEnter2D (Collider2D other) {
		if(other.name == "PC"){
			// LevelManager.RespawnPlayer();
			if(HealthManager.TakeDamage(1)){
				print("Attacking player");
				Vector2 Dir = other.transform.position - transform.position;
				Dir = new Vector2(Dir.x,Dir.y+10);
				Dir = Dir.normalized;
				other.GetComponent<Rigidbody2D>().AddForce(Dir*1000);
			}
		}
	}
}
