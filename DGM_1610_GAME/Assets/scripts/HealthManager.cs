using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour {
	public static int Health;
	public int MaxHealth;
	public static bool IsImmortal;
	public float ImmortalDuration;
	public static HealthManager HealthManagerObj;
	public SpriteRenderer PlayerSprite;

	Text HealthText;
	public LevelManager LevelManagerObj;

	// Use this for initialization
	void Start () {
		HealthText = GetComponent<Text>();
		HealthManagerObj = this;
		Health = MaxHealth;

	}
	
	// Update is called once per frame
	void Update () {
		if (Health <= 0){
			Health = 0;
			if(!LevelManager.PlayerIsDead){
				LevelManagerObj.RespawnPlayer();
			}
		}
		else if(Health > MaxHealth){
			Health = MaxHealth;
		}
		HealthText.text = "Health: " + Health + "/" + MaxHealth;
	}

	public static void AddHealth (int HealthToAdd){
		Health += HealthToAdd;
	}
	public static bool TakeDamage (int Damage){
		if(!IsImmortal){
			Health -= Damage;
			HealthManagerObj.StartCoroutine("MakeImmortal");
			return true;
		}
		return false;
	}
	
	public IEnumerator MakeImmortal(){
		IsImmortal = true;
		yield return new WaitForSeconds(ImmortalDuration);
		IsImmortal = false;
	}
}

