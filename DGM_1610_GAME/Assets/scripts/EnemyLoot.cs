using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLoot : MonoBehaviour {

	public string[] PossibleLoot = new string[2];
	public string Loot;
	public int yOffset;
	public int xOffset;

	// Use this for initialization
	void Start () {
		int i = Random.Range(0,PossibleLoot.Length);
		Loot = PossibleLoot[i];
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
