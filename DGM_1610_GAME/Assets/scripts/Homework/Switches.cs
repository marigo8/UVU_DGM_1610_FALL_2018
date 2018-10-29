using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switches : MonoBehaviour {

	public int num;
	public string name;

	// Homework
	public int PlayerScore;
	public string PlayerName;
	public float PlayerVelocity;
	public bool PlayerVictory;

	// Use this for initialization
	void Start () {
		
		// if(num == 10){
		// 	print("Hurray! you picked 10.");
		// }
		// else{
		// 	print("Boo! You did not pick 10.");
		// }

		// switch(num){
			
		// 	case 1:
		// 		print("You picked " + num);
		// 	break;

		// 	case 3:
		// 		print("You picked " + num);
		// 	break;

		// 	case 6:
		// 		print("You picked " + num);
		// 	break;

		// 	case 10:
		// 		print("You picked " + num);
		// 	break;

		// 	default:
		// 		print("I just don't even " + num);
		// 	break;
		// }

		// switch(name){
		// 	case "Jason":
		// 		print("Welcome to camp crystal lake, " + name + " - love mother");
		// 	break;

		// 	case "Michael":
		// 		print("Welcome to Haddonfield, IL " + name);
		// 	break;

		// 	case "Freddie":
		// 		print("Welcome to Elm Street, " + name);
		// 	break;

		// 	case "Leatherface":
		// 	case "leatherface":
		// 	case "LeatherFace":
		// 	case "leatherFace":
		// 		print("The stars and stripes are big at night... Deep in the heart of Texas");
		// 	break;

		// 	default:
		// 		print("I just don't even " + name);
		// 	break;
		// }

		/**************\
			HOMEWORK
		\**************/

		switch(PlayerScore){
			case 0:
				print("You didn't win.");
			break;

			case 1:
				print("It's better than 0 I guess");
			break;

			case 2:
				print("I've seen better.");
			break;

			case 3:
				print("I guess your score is okay.");
			break;

			case 4:
				print("Average.");
			break;

			case 5:
				print("Perfect.");
			break;

			default:
				print("How did you score " + PlayerScore + "!?!?!?!?");
			break;
		}
		switch(PlayerName){

			case "Player":
				print("That name is not very creative.");
			break;

			case "Pooplord666":
				print("That name is stupid");
			break;

			default:
				print("Welcome to the game," + PlayerName + "!");
			break;
		}
		// switch(PlayerVelocity){

		// 	case 0.0f:
		// 		print("Player is not moving");
		// 	break;

		// 	case 0.1f:
		// 	case 0.2f:
		// 	case 0.3f:
		// 		print("Player is moving slowly");
		// 	break;

		// 	case 0.4f:
		// 	case 0.5f:
		// 	case 0.6f:
		// 		print("Player is moving at moderate speed");
		// 	break;

		// 	case 0.7f:
		// 	case 0.8f:
		// 	case 0.9f:
		// 		print("Player is moving fast");
		// 	break;
		// 	case 1.0f:
		// 		print("Player is moving at peak speed");
		// 	break;
		// 	default:
		// 		print("Player's speed is incalculable");
		// 	break;
		// }


	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
