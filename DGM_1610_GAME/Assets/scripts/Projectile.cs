using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {

	public float Speed;
	public GameObject PC;
	
	public GameObject EnemyDeath;

	public GameObject HitParticle;

	public int PointsForKill;

	public float TimeOut;

	// Use this for initialization
	void Start () {
		PC = GameObject.Find("PC");

		EnemyDeath = Resources.Load("Prefabs/Enemy Death Particle") as GameObject;
		HitParticle = Resources.Load("Prefabs/Projectile Particle") as GameObject;

		if(PC.transform.localScale.x < 0){
			Speed = -Speed;
		}
		// GetComponent<Rigidbody2D>().velocity = new Vector2(Speed, GetComponent<Rigidbody2D>().velocity.y);
		Destroy(gameObject, TimeOut);
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<Rigidbody2D>().velocity = new Vector2(Speed, GetComponent<Rigidbody2D>().velocity.y);
	}

	void OnTriggerEnter2D(Collider2D other){
		if(other.tag == "Enemy"){
			Instantiate(EnemyDeath, other.transform.position, other.transform.rotation);
			Destroy (other.gameObject);
			Instantiate(
				Resources.Load("Prefabs/"+other.GetComponent<EnemyLoot>().Loot),
				new Vector3(
					other.transform.position.x + other.GetComponent<EnemyLoot>().xOffset,
					other.transform.position.y + other.GetComponent<EnemyLoot>().yOffset,
					other.transform.position.z
				), 
				other.transform.rotation
			);
			ScoreManager.AddPoints (PointsForKill);
			Destroy(gameObject);
			Instantiate(HitParticle, transform.position, transform.rotation);
		}
		// if(other.tag != "Coin" && other.tag != "Projectile"){
		// 	Instantiate(HitParticle, transform.position, transform.rotation);
		// 	StartCoroutine(DestroyParticle());
		// }
	}

	void OnCollisionEnter2D(Collision2D other){
		if(other.gameObject.tag != "Coin" && other.gameObject.tag != "Projectile"){
			Instantiate(HitParticle, transform.position, transform.rotation);
			// StartCoroutine(DestroyParticle());
			Destroy (gameObject, .01f);
		}
	}

	// IEnumerator DestroyParticle(){
	// 	yield return new WaitForSeconds(.01f);
	// 	Destroy (gameObject);
	// }
}
