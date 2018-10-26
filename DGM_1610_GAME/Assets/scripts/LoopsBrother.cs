using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopsBrother : MonoBehaviour {

	public int NumberOfAnts = 40;

	public string Color = "Blue";
	
	private bool IsBlack;

	public int CrackerCount = 1000;

	private bool IsTikTokStupid = true;

	private string WilhelmScream = "";

	public int TimeLeftToDoProject;

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

		/**************\
		|	HOMEWORK   |
		\**************/

		// Checkerboard Generator (for loops 1 and 2)
		for(int x = 0; x < 8; x++){ // x axis
			for(int y = 0; y < 8; y++){ // y axis
				IsBlack = !IsBlack;
				if(IsBlack){
					print("Square (" + x + "," + y + ") is Black");
				}else{
					print("Square (" + x + "," + y + ") is White");
				}
			}
		}
		// for loop 3
		for(int i = 0; i < 100; i++){
			WilhelmScream += "A";
		}
		print(WilhelmScream);
		// while loop 1
		while(!IsTikTokStupid){
			// This Code will never run because Tik Tok is stupid.
			IsTikTokStupid = true; // just in case.
			print("something went wrong.");
		}

		// while loop 2
		while(CrackerCount > 0){
			CrackerCount--;
			print("I have eaten a cracker and have "+ CrackerCount +" left.");
		}

		// while loop 3
		while(TimeLeftToDoProject > 0){
			print("I'll work on it later.");
			TimeLeftToDoProject--;
		}

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
