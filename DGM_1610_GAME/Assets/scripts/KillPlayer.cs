using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayer : MonoBehaviour {

	public LevelManager LevelManager;
	public float KnockbackX;
	public float KnockbackY;

	// Use this for initialization
	void Start () {
		LevelManager = FindObjectOfType <LevelManager>();
	}
	
	// Update is called once per frame
	void OnTriggerEnter2D (Collider2D other) {
		
		if(!Pause.Paused){
			if(other.name == "PC"){
				// LevelManager.RespawnPlayer();
				if(HealthManager.TakeDamage(1)){
					print("Attacking player");
					Vector2 Dir = other.transform.position - transform.position;
					Dir = new Vector2(Dir.x,Dir.y+KnockbackY);
					Dir = Dir.normalized;
					other.GetComponent<Rigidbody2D>().AddForce(Dir*KnockbackX);
					// https://answers.unity.com/questions/1100879/push-object-in-opposite-direction-of-collision.html
				}
			}
		}
	}
}
