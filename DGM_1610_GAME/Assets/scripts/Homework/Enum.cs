using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enum : MonoBehaviour {

	public enum Inventory : int {
		cheese, 
		meat, 
		sword, 
		shield,
		map, 
		backpack, 
		bow, 
		arrows
	};

	// Use this for initialization
	void Start () {
		print("Cheese: "+Inventory.cheese);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
