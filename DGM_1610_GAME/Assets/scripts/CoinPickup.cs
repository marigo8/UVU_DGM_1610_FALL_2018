using System.Collections;
using UnityEngine;

public class CoinPickup : MonoBehaviour {

	public int CoinValue;

	void OnTriggerEnter2D (Collider2D Other){
		if (Other.GetComponent<CharacterMove> () == null){
			return;
		}
		ScoreManager.AddPoints (CoinValue);

		Destroy (gameObject);
	}
}
