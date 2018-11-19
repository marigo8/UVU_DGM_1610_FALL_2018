using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour {

	// Movement Variables
	// public float MoveSpeed;
	public float MoveAcceleration;
	public float MoveMaxVelocity;
	public bool MoveRight;

	// Wall Check
	public Transform WallCheck;
	public float WallCheckRadius;
	public LayerMask WhatIsWall;
	private bool HittingWall;

	// Edge Check
	private bool NotAtEdge;
	public Transform EdgeCheck;
	
	// Update is called once per frame
	void Update () {
		// Check if near edge
		NotAtEdge = Physics2D.OverlapCircle(EdgeCheck.position, WallCheckRadius, WhatIsWall);

		// Check if hitting wall
		HittingWall = Physics2D.OverlapCircle(WallCheck.position, WallCheckRadius, WhatIsWall);

		// Bounce off wall.
		if (HittingWall || !NotAtEdge){
			MoveRight = !MoveRight;
		}

		// Flip sprite if needed.
		if (MoveRight){ // Face Right
			transform.localScale = new Vector3(.4f,.4f,1f);
			//GetComponent<Rigidbody2D>().velocity = new Vector2(MoveSpeed, GetComponent<Rigidbody2D>().velocity.y);
			if(GetComponent<Rigidbody2D>().velocity.x < MoveMaxVelocity){
				GetComponent<Rigidbody2D>().AddForce(new Vector2(MoveAcceleration,0));
			}
		}
		else{ // Face Left
			
			transform.localScale = new Vector3(-.4f,.4f,1f);
			// GetComponent<Rigidbody2D>().velocity = new Vector2(-MoveSpeed, GetComponent<Rigidbody2D>().velocity.y);
			if(GetComponent<Rigidbody2D>().velocity.x > -MoveMaxVelocity){
				GetComponent<Rigidbody2D>().AddForce(new Vector2(-MoveAcceleration,0));
			}
		}
	}
}
