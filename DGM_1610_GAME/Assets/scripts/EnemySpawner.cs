using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {

	public GameObject Enemy;

	// Use this for initialization
	void Start () {
		Enemy = Resources.Load("Prefabs/Enemy 1") as GameObject;
	}
	
	// Update is called once per frame
	void Update () {
		if(!Pause.Paused){
			if(Input.GetKeyDown(KeyCode.E)){
				SpawnEnemy();
			}
		}
	}

	void SpawnEnemy(){
		Instantiate(Enemy, transform.position, transform.rotation);
	}
}
