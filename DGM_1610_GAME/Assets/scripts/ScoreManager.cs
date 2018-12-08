using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour {
	public static int Score;
	public int WinScore;
	public bool WonGame;

	public Text WinText;

	public static GameObject PointsTextPrefab;

	Text ScoreText;

	void Awake(){
		//Time.timeScale = 1;
		Pause.PlayGame();
	}

	// Use this for initialization
	void Start () {
		WonGame = false;
		ScoreText = GetComponent<Text>();
		
		PointsTextPrefab = Resources.Load("Prefabs/PointsText") as GameObject;

		Score = 0;

		WinText.GetComponent<Text>().enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (Score < 0){
			Score = 0;
		}
		ScoreText.text = "Score: " + Score;

		// if(Score >= WinScore){
		// 	WinGame();
		// }

		

	}

	public void WinGame (){
			if(!WonGame){
				WinText.GetComponent<Text>().enabled = true;
				Time.timeScale = 0.25f;
				//Pause.PauseGame();
				StartCoroutine("LoadWinScreen");
			}
			if(Input.GetKeyDown(KeyCode.Escape)){
			SceneManager.LoadScene(0);
			}

			if(Input.GetKeyDown(KeyCode.Return)){
				SceneManager.LoadScene(2);
			}

	}

	public static void AddPoints (int PointsToAdd, Vector3 Position){
		string PointsText = "";
		TextMesh PointsTextObj;
		if(PointsToAdd >= 0){
			PointsText = "+" + PointsToAdd;
		}else{
			PointsText = "" + PointsToAdd;
		}
		Score += PointsToAdd;
		PointsTextObj = Instantiate(PointsTextPrefab, Position, new Quaternion()).GetComponent<TextMesh>();
		PointsTextObj.text = PointsText;
	}

	public IEnumerator LoadWinScreen(){
		if(!WonGame){
			WonGame = true;
			yield return new WaitForSecondsRealtime(5);
			SceneManager.LoadScene(2);
		}
	}
}
