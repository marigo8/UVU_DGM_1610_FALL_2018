/*******************\
	
	CharacterMove

\*******************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove : MonoBehaviour {

	// Player Movement Variables
	public float MoveSpeed;
	public float JumpHeight;

	// Player Grounded Variables
	public Transform GroundCheck;
	public float GroundCheckRadius;
	public LayerMask WhatIsGround;
	private bool Grounded;

	// Use this for initialization
	void Start () {
		print("Hello, World!");
	}

	void FixedUpdate () {
		// Set Grounded variable
		Grounded = Physics2D.OverlapCircle(GroundCheck.position, GroundCheckRadius, WhatIsGround);
	}
	
	// Update is called once per frame
	void Update () {

		// MOVEMENT CONTROLS
			// Jump
			if(Input.GetKeyDown (KeyCode.Space) && Grounded){
				Jump();
			}

			// Move Right
			if(Input.GetKey (KeyCode.D)){
				// velocity.x = velocity.x + MoveSpeed;
				GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x+MoveSpeed, GetComponent<Rigidbody2D>().velocity.y);
			}
			// Move Left
			if(Input.GetKey (KeyCode.A)){
				// velocity.x = velocity.x - MoveSpeed;
				GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x-MoveSpeed, GetComponent<Rigidbody2D>().velocity.y);
			}
	}

	// Character Jump Function
	public void Jump(){
		// velocity.y = JumpHeight;
		GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, JumpHeight);
	}
}
