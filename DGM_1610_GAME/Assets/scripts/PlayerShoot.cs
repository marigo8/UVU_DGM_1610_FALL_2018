using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour {

	// Shoot Variables
	public Transform FirePoint;
	public GameObject Projectile;
	public AmmoManager AmmoManagerObj;

	// Use this for initialization
	void Start () {
		Projectile = Resources.Load("Prefabs/Orb Projectile") as GameObject;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.RightControl)){
			if(AmmoManagerObj.HasAmmo){
				print("Shooting Projectile");
				Instantiate(Projectile, FirePoint.position, FirePoint.rotation);
				AmmoManager.UseAmmo();
			}
		}
	}
}
