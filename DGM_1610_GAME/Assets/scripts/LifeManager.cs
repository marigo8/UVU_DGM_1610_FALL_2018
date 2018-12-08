using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LifeManager : MonoBehaviour {
	public static int Lives;
	public int StartingLives;

	public bool LostGame;

	Text LivesText;
	public Text LoseText;
	public LevelManager LevelManagerObj;

	// Use this for initialization
	void Start () {
		LivesText = GetComponent<Text>();
		Lives = StartingLives;
		LoseText.GetComponent<Text>().enabled = false;

	}
	
	// Update is called once per frame
	void Update () {
		if (Lives <= 0){
			Lives = 0;
			GameOver();
		}
		LivesText.text = "Lives: " + Lives;
	}

	public static void RemoveLife (){
		print("Removing 1 Life");
		Lives -= 1;
	}

	public void GameOver (){
			if(!LostGame){
				LoseText.GetComponent<Text>().enabled = true;
				Time.timeScale = 0.25f;
				//Pause.PauseGame();
				StartCoroutine("LoadGameOverScreen");
			}
			if(Input.GetKeyDown(KeyCode.Escape)){
			SceneManager.LoadScene(0);
			}

			if(Input.GetKeyDown(KeyCode.Return)){
				SceneManager.LoadScene(2);
			}

	}
	public IEnumerator LoadGameOverScreen(){
		if(!LostGame){
			LostGame = true;
			yield return new WaitForSecondsRealtime(2);
			SceneManager.LoadScene(3);
		}
	}
}
