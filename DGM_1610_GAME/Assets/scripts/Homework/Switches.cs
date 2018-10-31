using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switches : MonoBehaviour {

	public int num;
	public string name;

	// Homework
	public int PlayerScore;
	public string PlayerName;
	public int PlayerVelocity;
	public string ConsoleInput;
	public int PlayerKillCount;

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
				print("Welcome to the game, " + PlayerName + "!");
			break;
		}
		switch(PlayerVelocity){

			case 0:
				print("Player is not moving");
			break;

			case 1:
			case 2:
			case 3:
				print("Player is moving slowly");
			break;

			case 4:
			case 5:
			case 6:
				print("Player is moving at moderate speed");
			break;

			case 7:
			case 8:
			case 9:
				print("Player is moving fast");
			break;
			case 10:
				print("Player is moving at peak speed");
			break;
			default:
				print("Player's speed is incalculable");
			break;
		}
		switch(ConsoleInput){
			
			case "help":
				print("No.");
			break;
			
			case "give 999999999 money":
				print("Value must be between (0) and (255).");
			break;
			
			case "teleport":
				print("You do not have permission to do that.");
			break;
			
			case "unstuck":
				print("Sorry, but I cannot help you.");
			break;
			
			default:
				print("That command does not exist.");
			break;
		}
		switch(PlayerKillCount){
			
			case 0:
				print("Get back to work.");
			break;
			
			case 1:
				print("You got a kill.");
			break;
			
			case 2:
				print("Double kill!");
			break;
			
			case 3:
				print("Triple kill!");
			break;
			
			case 4:
				print("Overkill!");
			break;
			
			case 5:
				print("Killtacular!");
			break;
			
			case 6:
				print("Killtrocity!");
			break;
			
			case 7:
				print("Killimanjaro!");
			break;
			
			case 8:
				print("Killtastrophe!");
			break;
			
			case 9:
				print("Killpocalypse!");
			break;
			
			case 10:
				print("Killionaire!");
			break;

			default:
				print("Boi, chill.");
			break;
		}


	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
