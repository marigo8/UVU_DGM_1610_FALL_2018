using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

	public GameObject CurrentCheckPoint;
	private Controller2D Player;

	// Particles
	public GameObject DeathParticle;
	public GameObject RespawnParticle;

	// Respawn Delay
	public float RespawnDelay;

	// Point Penalty on Death
	public int PointPenaltyOnDeath;

	// Store Gravity Value
	private float GravityStore;

	// Use this for initialization
	void Start () {
		Player = FindObjectOfType<CharacterMove> ();
	}

	public void RespawnPlayer(){
		StartCoroutine("RespawnPlayerCo");
	}

	public IEnumerator RespawnPlayerCo(){

		// Generate Death Particle
		Instantiate (DeathParticle, Player.transform.position, Player.transform.rotation);

		// Hide Player
		//Player.enabled = false;
		Player.GetComponent<Renderer> ().enabled = false;

		// Gravity Reset
		GravityStore = Player.GetComponent<Rigidbody2D>().GravityScale;
		Player.GetComponent<Rigidbody2D>().gravityScale = 0f;
		Player.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
		
		// Point Penalty
		ScoreManager.AddPoints(-PointPenaltyOnDeath);

		// Debug Message
		Debug.Log ("Player Respawn");
	}
}
