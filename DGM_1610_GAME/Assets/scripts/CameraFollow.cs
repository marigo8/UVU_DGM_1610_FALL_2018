using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

	public CharacterMove PC;

	public bool IsFollowing;

	public float xOffset;
	public float yOffset;

	// Use this for initialization
	void Start () {
		PC = FindObjectOfType<CharacterMove>();

		IsFollowing = true;
	}
	
	// Update is called once per frame
	void LateUpdate () {
		if(!Pause.Paused){

			if(Input.GetKeyDown(KeyCode.L)){
				IsFollowing = !IsFollowing;
			}

			if(IsFollowing){
				transform.position = new Vector3(
					((PC.transform.position.x + xOffset + transform.position.x) / 2),
					((PC.transform.position.y + yOffset + transform.position.y) / 2),
					transform.position.z);
			}
		}
	}
}
