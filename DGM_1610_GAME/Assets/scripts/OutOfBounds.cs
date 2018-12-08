using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutOfBounds : MonoBehaviour {

	public LevelManager LevelManager;
	public bool KilledPlayer;

	// Use this for initialization
	void Start () {
		LevelManager = FindObjectOfType <LevelManager>();
	}
	
	// Update is called once per frame
	void OnTriggerEnter2D (Collider2D other) {
		if(!Pause.Paused){
			if(other.name == "PC"){
				if(!KilledPlayer){
					KilledPlayer = true;
					LevelManager.RespawnPlayer();
					StartCoroutine("WaitForRespawn");
				}
			}
			else if(other.name != "GroundCheck"){
				print("Destroying "+other.name);
				Destroy(other.gameObject);
			}
		}
	}
	public IEnumerator WaitForRespawn(){
		yield return new WaitForSecondsRealtime(.5f);
		KilledPlayer = false;
	}
}