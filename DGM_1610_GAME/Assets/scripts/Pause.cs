using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour {

	public static bool Paused;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.P)){
			if(Paused){
				PlayGame();
			}
			else{
				PauseGame();
			}
		}
	}

	public static void PauseGame () {
		// Rigidbody2D[] PhysicsObjects = FindObjectsOfType<Rigidbody2D>();
		// foreach (Rigidbody2D PhysicsObject in PhysicsObjects){
		// 	PhysicsObject.simulated = false;
		// 	Paused = true;
		// }
		Time.timeScale = 0;
		Paused = true;
	}

	public static void PlayGame () {
		// Rigidbody2D[] PhysicsObjects = FindObjectsOfType<Rigidbody2D>();
		// foreach (Rigidbody2D PhysicsObject in PhysicsObjects){
		// 	PhysicsObject.simulated = true;
		// 	Paused = false;
		// }
		Time.timeScale = 1;
		Paused = false;
	}
}
