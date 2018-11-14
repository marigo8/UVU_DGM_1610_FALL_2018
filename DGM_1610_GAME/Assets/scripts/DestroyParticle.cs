using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyParticle : MonoBehaviour {

	private ParticleSystem ThisParticleSystem;

	// public float LifeTime;

	// Use this for initialization
	void Start () {
		ThisParticleSystem = GetComponent<ParticleSystem>();
		// Destroy(gameObject, LifeTime);
	}
	
	// Update is called once per frame
	void Update () {
		if(!ThisParticleSystem.isPlaying){
			Destroy(gameObject);
		}
	}
	void OnBecameInvisible(){
		Destroy (gameObject);
	}
}
