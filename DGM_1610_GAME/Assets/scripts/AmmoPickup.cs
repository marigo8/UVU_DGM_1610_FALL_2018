using System.Collections;
using UnityEngine;

public class AmmoPickup : MonoBehaviour {

	public int AmmoValue;
	public AmmoManager AmmoManagerObj;

	void start(){
		AmmoManagerObj = GetComponent<AmmoManager>();
	}

	void OnTriggerEnter2D (Collider2D Other){
		if (Other.GetComponent<CharacterMove> () == null){
			return;
		}
		print("Ammo Value:"+AmmoValue);
		AmmoManager.AddAmmo (AmmoValue);

		Destroy (gameObject);
	}
}
