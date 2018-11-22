using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickup : MonoBehaviour {

	public int HealthPoints;
	public HealthManager HealthManagerObj;

	void start(){
		HealthManagerObj = GetComponent<HealthManager>();
	}

	void OnTriggerEnter2D (Collider2D Other){
		if (Other.GetComponent<CharacterMove> () == null){
			return;
		}
		HealthManager.AddHealth (HealthPoints);

		Destroy (gameObject);
	}
}
