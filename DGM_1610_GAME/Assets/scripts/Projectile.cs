using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {

	public float Speed;
	public float LifeTime;
	public Rigidbody2D PC;
	
	public GameObject EnemyDeath;

	public GameObject HitParticle;

	public int PointsForKill;

	// Use this for initialization
	void Start () {
		if(PC.transform.localScale.x < 0){
			Speed = -Speed;
		}
		GetComponent<Rigidbody2D>().velocity = new Vector2(Speed, GetComponent<Rigidbody2D>().velocity.y);
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnTriggerEnter2D(Collider2D other){
		if(other.tag == "Enemy"){
			Instantiate(EnemyDeath, other.transform.position, other.transform.rotation);
			Destroy (other.gameObject);
			ScoreManager.AddPoints (PointsForKill);
		}

		Instantiate(HitParticle, transform.position, transform.rotation);
		Destroy (gameObject);
	}

	IEnumerator LifeTimer(){
		yield return new WaitForSeconds(LifeTime);
		Destroy (gameObject);
	}
}
