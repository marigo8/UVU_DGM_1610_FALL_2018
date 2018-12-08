using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Time.timeScale = 1;
		
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Return)){
			PlayAgain();
		}
		if(Input.GetKeyDown(KeyCode.Escape)){
			GoToMainMenu();
		}
		
	}

	public void PlayAgain(){
		SceneManager.LoadScene(1);
	}

	public void GoToMainMenu(){
		SceneManager.LoadScene(0);
	}
}
