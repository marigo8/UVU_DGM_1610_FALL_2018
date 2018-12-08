using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinGoal : MonoBehaviour {

	public ScoreManager ScoreManagerObj;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D Other){
		if(Other.name == "PC"){
			ScoreManagerObj.WinGame();
		}
	}
}
