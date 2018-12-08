using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AmmoManager : MonoBehaviour {

	public static int AmmoCount;
	public int StartAmmo;
	public int RespawnAmmo;
	public int AmmoCap;
	Text AmmoText;
	[HideInInspector] public bool HasAmmo;

	// Use this for initialization
	void Start () {
		AmmoText = GetComponent<Text>();

		AmmoCount = StartAmmo;
	}
	
	// Update is called once per frame
	void Update () {
		if (AmmoCount > 0){
			if(AmmoCount > AmmoCap){
				AmmoCount = AmmoCap;
			}
			HasAmmo = true;
		}else{
			AmmoCount = 0;
			HasAmmo = false;
		}
		AmmoText.text = "Ammo: " + AmmoCount + "/" + AmmoCap;
	}

	public static void UseAmmo (){
		AmmoCount--;
	}
	public static void AddAmmo(int AmmoToAdd){
		AmmoCount += AmmoToAdd;
	}
}
