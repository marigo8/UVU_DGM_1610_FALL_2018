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
	public float AerialMoveSpeedModifier;
	public float MaxVelocity;
	public float JumpHeight;
	private bool DoubleJump;
	private float MoveSpeedModifier;
	private bool FacingRight = true;
	private Vector3 PlayerScale;

	// Player Grounded Variables
	// public Transform GroundCheck;
	// public float GroundCheckRadius;
	public Collider2D GroundCheck;
	public LayerMask WhatIsGround;
	public static bool Grounded;

	// Non-Stick Player
	private float MoveVelocity;

	// Animation variables
	public Animator AnimatorObj;


	// Use this for initialization
	void Start () {
		PlayerScale = transform.localScale;
	}

	// void FixedUpdate () {
	// 	Set Grounded variable
	// 	Grounded = Physics2D.OverlapCircle(GroundCheck.position, GroundCheckRadius, WhatIsGround);
	// }

	
	
	// Update is called once per frame
	void FixedUpdate () {
		if(!Pause.Paused){
			if(!LevelManager.PlayerIsDead){
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
					if(Grounded){ // if grounded...
						MoveVelocity = MoveSpeed*MoveSpeedModifier; // move normally (fixed velocity)
						AnimatorObj.SetBool("IsRunning", true);
					}else{ // if in the air
						GetComponent<Rigidbody2D>().AddForce(new Vector2(MoveSpeed*MoveSpeedModifier*Time.deltaTime * AerialMoveSpeedModifier,0));
						if(GetComponent<Rigidbody2D>().velocity.x > MoveSpeed*MoveSpeedModifier){
							GetComponent<Rigidbody2D>().velocity = new Vector2(MoveSpeed*MoveSpeedModifier, GetComponent<Rigidbody2D>().velocity.y);
						}
						// MoveVelocity = GetComponent<Rigidbody2D>().velocity.x + MoveSpeed*MoveSpeedModifier*0.1f; // move with dynamic velocity
						// if(MoveVelocity > MoveSpeed*MoveSpeedModifier){ // but cap it if it gets too high
						// 	MoveVelocity = MoveSpeed*MoveSpeedModifier;
						// }
						// GetComponent<Rigidbody2D>().velocity = new Vector2(MoveVelocity, GetComponent<Rigidbody2D>().velocity.y);
						// GetComponent<Rigidbody2D>().AddForce(new Vector2(MoveSpeed*MoveSpeedModifier*4,0));
					}
					// If player is not facing right
					if(!FacingRight){
						// Make Player face right
						//PlayerScale.x *= -1;
						transform.localScale = new Vector3(PlayerScale.x,PlayerScale.y,PlayerScale.z);
						// Player is now facing right
						FacingRight = true;
					}	
				}
				if(Input.GetKeyUp(KeyCode.D)){
					AnimatorObj.SetBool("IsRunning", false);
				}
				// Move Left
				if(Input.GetKey (KeyCode.A)){
					// velocity.x = velocity.x - Acceleration;
					// GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x-Acceleration, GetComponent<Rigidbody2D>().velocity.y);
					if(Grounded){
						MoveVelocity = -MoveSpeed*MoveSpeedModifier;
						AnimatorObj.SetBool("IsRunning", true);
					}else{
						GetComponent<Rigidbody2D>().AddForce(new Vector2(-MoveSpeed*MoveSpeedModifier*Time.deltaTime * AerialMoveSpeedModifier,0));
						if(GetComponent<Rigidbody2D>().velocity.x < -MoveSpeed*MoveSpeedModifier){
							GetComponent<Rigidbody2D>().velocity = new Vector2(-MoveSpeed*MoveSpeedModifier, GetComponent<Rigidbody2D>().velocity.y);
						}
						// MoveVelocity = GetComponent<Rigidbody2D>().velocity.x - MoveSpeed*MoveSpeedModifier*0.05f;
						// if(MoveVelocity < -MoveSpeed*MoveSpeedModifier){
						// 	MoveVelocity = -MoveSpeed*MoveSpeedModifier;
						// }

						// GetComponent<Rigidbody2D>().velocity = new Vector2(MoveVelocity, GetComponent<Rigidbody2D>().velocity.y);
						// GetComponent<Rigidbody2D>().AddForce(new Vector2(-MoveSpeed*MoveSpeedModifier*4,0));
					}
					// If player is facing right
					if(FacingRight){
						// Make Player Face left
						//PlayerScale.x *= -1;
						transform.localScale = new Vector3(-PlayerScale.x,PlayerScale.y,PlayerScale.z);
						// Player is no longer facing right
						FacingRight = false;
					}	
				}
				if(Input.GetKeyUp(KeyCode.A)){
					AnimatorObj.SetBool("IsRunning", false);
				}
				if(Grounded){
					AnimatorObj.SetBool("IsGrounded",true);
					GetComponent<Rigidbody2D>().velocity = new Vector2(MoveVelocity, GetComponent<Rigidbody2D>().velocity.y);
					MoveVelocity = 0;
					// GetComponent<Rigidbody2D>().velocity = new Vector2(MoveVelocity, GetComponent<Rigidbody2D>().velocity.y);
				}
				else{
					AnimatorObj.SetBool("IsGrounded",false);
				}
			}
			else{
				GetComponent<Rigidbody2D>().velocity = new Vector2(0,0);
			}
		}
	}
	// void LateUpdate(){
	// 	MoveVelocity = 0;
	// }

	// Character Jump Function
	public void Jump(){
		// velocity.y = JumpHeight;
		GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, JumpHeight);
	}
}
