using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

	public Transform Target;
	private Rigidbody2D TargetRB;
	public float Speed;

	public bool IsFollowing;

	public Vector2 offset;
	public float VelocityModifier;
	private float ZLock;
	private Vector3 OffsetTarget;

	// Use this for initialization
	void Start () {
		//Target = FindObjectOfType<CharacterMove>();
		ZLock = transform.position.z;

		IsFollowing = true;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if(!Pause.Paused){

			if(Input.GetKeyDown(KeyCode.L)){
				IsFollowing = !IsFollowing;
			}

			if(IsFollowing){
				TargetRB = Target.GetComponent<Rigidbody2D>();
				if(TargetRB){
					OffsetTarget = new Vector3(
						Target.position.x + offset.x + (TargetRB.velocity.x*VelocityModifier),
						Target.position.y + offset.y,
						ZLock
					);
				}else{
					OffsetTarget = new Vector3(
						Target.position.x + offset.x,
						Target.position.y + offset.y,
						ZLock
					);
				}

				float step = Vector3.Distance(transform.position,OffsetTarget)/(Speed*Time.deltaTime);

				transform.position = Vector3.MoveTowards(transform.position,OffsetTarget,step);
			}
		}
	}
}
