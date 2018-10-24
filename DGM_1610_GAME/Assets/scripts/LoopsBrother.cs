using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopsBrother : MonoBehaviour {

	public int NumberOfAnts = 40;

	public string Color = "Blue";

	// Use this for initialization
	void Start () {
		// for(int i = 0; i <= NumberOfAnts; i++){

		// 	print(i + " Ants marching");

		// }

		while(NumberOfAnts >= 0){
			print(NumberOfAnts + " Ants marching");
			NumberOfAnts--;
		}

		// while(Color == "Red"){
		// 	print("Color is " + Color);
			
		// }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
