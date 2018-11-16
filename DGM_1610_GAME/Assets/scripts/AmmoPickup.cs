using System.Collections;
using UnityEngine;

public class AmmoPickup : MonoBehaviour {

	public int AmmoValue;

	void OnTriggerEnter2D (Collider2D Other){
		if (Other.GetComponent<CharacterMove> () == null){
			return;
		}
		AmmoManager.AddAmmo (AmmoValue);

		Destroy (gameObject);
	}
}
