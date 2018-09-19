﻿/*******************\
	
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
		
	}

	void FixedUpdate () {
		// Set Grounded variable
		Grounded = Physics2D.OverlapCircle(GroundCheck.position, GroundCheckRadius, WhatIsGround);
	}
	
	// Update is called once per frame
	void Update () {

		// MOVEMENT CONTROLS
			// Jump
			if( (Input.GetKeyDown (KeyCode.Space) || Input.GetKeyDown (KeyCode.W)) && Grounded){
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

		// ReOrientate
		/*
		if(Input.GetKeyDown (KeyCode.F)){
			Jump();
			new WaitForSeconds(0.5f);
			//GetComponent<Transform>().rotation = new Vector3(GetComponent<Transform>().rotation.x, GetComponent<Transform>().rotation.y, 0.0f);
			GetComponent<Transform>().rotation.z = 0.0f;
		}
		*/
	}

	// Character Jump Function
	public void Jump(){
		// velocity.y = JumpHeight;
		GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, JumpHeight);
	}
}
