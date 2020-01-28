/*******************\
	
	CharacterMove

\*******************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove : MonoBehaviour {
	
	// Active
	public bool active = true;

	// Grounded
	public bool grounded;

	// Movement
	public float moveAcceleration;
	public float aerialAcceleration;
	public float moveMaxSpeed;
	public float moveSpeedIncrement;
	private float moveSpeed;
	private bool running;
	
	// Jump
	public float jumpSpeed;
	private bool doubleJump;
	private bool jumpReady;
	public float jumpCooldownTime;

	// Components
	private Rigidbody2D rb;
	private Animator anim;

	// Sprite direction
	private Vector3 playerScale;
	private bool facingRight;

	void Start(){
		rb = GetComponent<Rigidbody2D>();
		anim = GetComponent<Animator>();
		playerScale = transform.localScale;
		jumpReady = true;
	}

	void FixedUpdate(){
		if(active){
			rb.simulated = true;
			if(grounded){
				doubleJump = true;
			}
			// Move
			Move(Input.GetAxis("Horizontal"));

			// Jump
			if(Input.GetButtonDown("Jump")){
				Jump();
			}

			// Animation Parameters
			anim.SetBool("IsGrounded",grounded);
			anim.SetBool("IsRunning",running);
		}else{
			rb.simulated = false;
		}
	}
	public void Move(float direction){ // 1 = right; -1 = left; 0 = don't move;
		if(grounded){
			moveSpeed += moveSpeedIncrement*Time.deltaTime;
			if(moveSpeed > moveMaxSpeed){
				moveSpeed = moveMaxSpeed;
			}
			rb.velocity = new Vector2(moveSpeed * direction, rb.velocity.y);
				setSpriteDirection(direction);
		}
		else{
			moveSpeed = 0;
			rb.AddForce(Vector2.right * direction * aerialAcceleration);
			if(direction != 0){
				setSpriteDirection(rb.velocity.x);
			}
			

		}
		if(rb.velocity.x > moveMaxSpeed){
			rb.velocity = new Vector2(moveMaxSpeed,rb.velocity.y);
		}
		else if(rb.velocity.x < -moveMaxSpeed){
			rb.velocity = new Vector2(-moveMaxSpeed,rb.velocity.y);
		}

		if(direction != 0){
			running = true;
		}else{
			running = false;
		}
	}
	public void Jump(){
		if(jumpReady){
			if(grounded){
				rb.velocity = new Vector2(rb.velocity.x, jumpSpeed);
				StartCoroutine("JumpCooldown");
			}
			else if(doubleJump){
				rb.velocity = new Vector2(rb.velocity.x, jumpSpeed*1.25f);
				doubleJump = false;
				float direction = Input.GetAxis("Horizontal");
				StartCoroutine("JumpCooldown");
			}
		}
	}
	
	public IEnumerator JumpCooldown(){
		jumpReady = false;
		yield return new WaitForSeconds(jumpCooldownTime);
		jumpReady = true;
	}

	private void setSpriteDirection(float direction){
		if(direction > 0){
			transform.localScale = new Vector3(playerScale.x,playerScale.y,playerScale.z);
			facingRight = true;
		}
		else if(direction < 0){
			transform.localScale = new Vector3(-playerScale.x,playerScale.y,playerScale.z);
			facingRight = false;
		}
	}

}
