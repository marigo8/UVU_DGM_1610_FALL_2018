using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

	public Transform Target;
	public float Speed;

	public bool IsFollowing;

	public float xOffset;
	public float yOffset;
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
				// transform.position = new Vector3(
				// 	((Target.position.x + xOffset + transform.position.x) / 2),
				// 	((Target.position.y + yOffset + transform.position.y) / 2),
				// 	transform.position.z);
				OffsetTarget = new Vector3(
					Target.position.x + xOffset,
					Target.position.y + yOffset,
					ZLock
				);

				float step = Vector3.Distance(transform.position,OffsetTarget)/(Speed*Time.deltaTime);

				transform.position = Vector3.MoveTowards(transform.position,OffsetTarget,step);
			}
		}
	}
}
