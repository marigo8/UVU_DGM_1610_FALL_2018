using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

	// Is Player Dead?
	public static bool PlayerIsDead = false;

	// Current CheckPoint
	public GameObject CurrentCheckPoint;

	// Player Controller
	public Rigidbody2D Player;
	public GameObject PlayerObject;

	// Particles
	public GameObject DeathParticle;
	public GameObject RespawnParticle;

	// Respawn Delay
	public float RespawnDelay;

	// Point Penalty on Death
	public int PointPenaltyOnDeath;

	// Store Gravity Value
	private float GravityStore;

	// Ammo
	public AmmoManager AmmoManagerObj;

	// Health
	public HealthManager HealthManagerObj;

	// Use this for initialization
	void Start () {
		// Get Player Object on game start
		// Player = FindObjectOfType<Rigidbody2D> ();

		DeathParticle = Resources.Load("Prefabs/Death Particle") as GameObject;
		RespawnParticle = Resources.Load("Prefabs/Respawn Particle") as GameObject;
	}
	void Update (){
	}

	public void RespawnPlayer(){
		StartCoroutine("RespawnPlayerCo");
	}

	public IEnumerator RespawnPlayerCo(){

		// Player is Dead
		PlayerIsDead = true;

		// Generate Death Particle
		Instantiate (DeathParticle, Player.transform.position, Player.transform.rotation);

		// Hide Player
		//Player.enabled = false;
		//Player.simulated = false;
		PlayerObject.SetActive(false);
		Player.Sleep();
		Player.GetComponent<PolygonCollider2D>().enabled = false;
		Player.GetComponent<Renderer>().enabled = false;
		
		// Point Penalty
		ScoreManager.AddPoints(-PointPenaltyOnDeath);

		// Debug Message
		// Debug.Log ("Player Respawn");

		// Respawn Delay
		yield return new WaitForSeconds (RespawnDelay);

		// Gravity Reset
		GravityStore = Player.GetComponent<Rigidbody2D>().gravityScale;
		Player.GetComponent<Rigidbody2D>().gravityScale = 0f;
		Player.GetComponent<Rigidbody2D>().velocity = Vector2.zero;

		// Gravity Restore
		Player.GetComponent<Rigidbody2D>().gravityScale = GravityStore;

		// Match Players transform position
		Player.transform.position = CurrentCheckPoint.transform.position;

		// Show Player
		// Player.enabled = true;
		//Player.simulated = true;
		PlayerObject.SetActive(true);
		Player.WakeUp();
		Player.GetComponent<PolygonCollider2D>().enabled = true;
		Player.GetComponent<Renderer> ().enabled = true;

		// Player is Alive Again
		PlayerIsDead = false;

		// Reset Health
		HealthManager.Health = HealthManagerObj.MaxHealth;

		// Refill Ammo
		AmmoManager.AmmoCount = AmmoManagerObj.RespawnAmmo;

		// Spawn Particle
		Instantiate (RespawnParticle, CurrentCheckPoint.transform.position, CurrentCheckPoint.transform.rotation);
	}
}