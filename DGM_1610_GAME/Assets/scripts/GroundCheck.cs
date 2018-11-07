using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour {

	public string WhatIsGround;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerStay2D (Collider2D other){
		if(other.tag == WhatIsGround){
			CharacterMove.Grounded = true;
		}
		else{
		}
	}
	void OnTriggerExit2D (Collider2D other){
		if(other.tag == WhatIsGround){
			CharacterMove.Grounded = false;
		}
	}
}
