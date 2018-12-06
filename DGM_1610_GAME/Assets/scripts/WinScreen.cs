using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class WinScreen : MonoBehaviour {

	public Text SubTotalScoreText;
	public Text HealthText;
	public Text AmmoText;
	public Text ScoreText;

	public float ScoreDelay;

	public int TotalScore;

	// Use this for initialization
	void Start () {
		Time.timeScale = 1;
		TotalScore = ScoreManager.Score + AmmoManager.AmmoCount + HealthManager.Health;
		StartCoroutine("DisplayScore");
		
		
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

	public IEnumerator DisplayScore(){
		yield return new WaitForSeconds(ScoreDelay);
		SubTotalScoreText.text = ""+ScoreManager.Score;

		yield return new WaitForSeconds(ScoreDelay);
		HealthText.text = "+"+HealthManager.Health;

		yield return new WaitForSeconds(ScoreDelay);
		AmmoText.text = "+"+AmmoManager.AmmoCount;

		yield return new WaitForSeconds(ScoreDelay);
		ScoreText.text = ""+TotalScore;
	}
}
