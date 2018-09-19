using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VarFunc : MonoBehaviour {

	// 3 variables, vary access modifiers, 3 datatypes, assign at least 1 value

	public float Health;
	public float Shields;
	public int Acceleration = 2;
	private Transform PlayerTransform;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	// 3 functions

	void PlayerTakeDamage(float Damage){
		Health = Health - Damage*2/Shields;
	}
	void PlayerMoveRight(){
		GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x+Acceleration, GetComponent<Rigidbody2D>().velocity.y);
	}
	void PlayerMoveLeft(){
		GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x-Acceleration, GetComponent<Rigidbody2D>().velocity.y);
	}
}
