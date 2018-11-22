using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour {
	public static int Health;
	public int MaxHealth;

	Text HealthText;
	public LevelManager LevelManagerObj;

	// Use this for initialization
	void Start () {
		HealthText = GetComponent<Text>();

		Health = MaxHealth;
	}
	
	// Update is called once per frame
	void Update () {
		if (Health <= 0){
			if(!LevelManager.PlayerIsDead){
				LevelManagerObj.RespawnPlayer();
			}
		}
		else if(Health > MaxHealth){
			Health = MaxHealth;
		}
		HealthText.text = "Health: " + Health;
	}

	public static void AddHealth (int HealthToAdd){
		Health += HealthToAdd;
	}

	public static void TakeDamage (int Damage){
		Health -= Damage;
	}
}
