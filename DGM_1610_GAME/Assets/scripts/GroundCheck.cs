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
			print("hitting ground!");
			CharacterMove.Grounded = true;
		}
		else{
			print("other is not ground!");
		}
	}
	void OnTriggerExit2D (Collider2D other){
		if(other.tag == WhatIsGround){
			print("leaving ground!");
			CharacterMove.Grounded = false;
		}
	}
}
