/*******************\
	
	CharacterMove

\*******************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove : MonoBehaviour {

	// Player Movement Variables
	public float MoveSpeed;
	public float SprintModifier;
	public float MaxVelocity;
	public float JumpHeight;
	private bool DoubleJump;
	private float MoveSpeedModifier;

	// Player Grounded Variables
	public Transform GroundCheck;
	public float GroundCheckRadius;
	public LayerMask WhatIsGround;
	private bool Grounded;

	// Non-Stick Player
	private float MoveVelocity;

	// Use this for initialization
	void Start () {
		
	}

	void FixedUpdate () {
		// Set Grounded variable
		Grounded = Physics2D.OverlapCircle(GroundCheck.position, GroundCheckRadius, WhatIsGround);
	}
	
	// Update is called once per frame
	void Update () {
		// Sprint
		if(Input.GetKey (KeyCode.LeftShift)){
			MoveSpeedModifier = SprintModifier;
		}else{
			MoveSpeedModifier = 1;
		}
		// Jump
		if( (Input.GetKeyDown (KeyCode.Space) || Input.GetKeyDown (KeyCode.W)) && Grounded){
			Jump();
		}

		// Double Jump
		if(Grounded){
			DoubleJump = false;
		}
		if( (Input.GetKeyDown (KeyCode.Space) || Input.GetKeyDown (KeyCode.W)) && !DoubleJump && !Grounded){
			Jump();
			DoubleJump = true;
		}

		// Non-Stick Player
		if(Grounded){
			MoveVelocity = 0f;
		}
		// Move Right
		if(Input.GetKey (KeyCode.D)){
			// velocity.x = velocity.x + Acceleration;
			// GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x+Acceleration, GetComponent<Rigidbody2D>().velocity.y);
			if(Grounded){
				MoveVelocity = MoveSpeed*MoveSpeedModifier;
			}else{
				MoveVelocity += MoveSpeed*MoveSpeedModifier*0.1f;
				if(MoveVelocity > MoveSpeed*MoveSpeedModifier){
					MoveVelocity = MoveSpeed*MoveSpeedModifier;
				}
				GetComponent<Rigidbody2D>().velocity = new Vector2(MoveVelocity, GetComponent<Rigidbody2D>().velocity.y);
			}
		}
		// Move Left
		if(Input.GetKey (KeyCode.A)){
			// velocity.x = velocity.x - Acceleration;
			// GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x-Acceleration, GetComponent<Rigidbody2D>().velocity.y);
			if(Grounded){
				MoveVelocity = -MoveSpeed*MoveSpeedModifier;
			}else{
				MoveVelocity -= MoveSpeed*MoveSpeedModifier*0.05f;
				if(MoveVelocity < -MoveSpeed*MoveSpeedModifier){
					MoveVelocity = -MoveSpeed*MoveSpeedModifier;
				}
				GetComponent<Rigidbody2D>().velocity = new Vector2(MoveVelocity, GetComponent<Rigidbody2D>().velocity.y);
			}
		}
		if(Grounded){
			GetComponent<Rigidbody2D>().velocity = new Vector2(MoveVelocity, GetComponent<Rigidbody2D>().velocity.y);
		}
	}

	// Character Jump Function
	public void Jump(){
		// velocity.y = JumpHeight;
		GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, JumpHeight);
	}
}
