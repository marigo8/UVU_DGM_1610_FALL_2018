using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour {
	
	public int[] Eggs = new int[12];

	public string[] Jedi;

	// Homework Variables (5 arrays, 5 foreach loops)

	public string[] PossibleLoot = new string[6];
	public float[] PotatoSizes = new float[8];
	public int[] PlayerScores = new int[4];
	public string[] PlayerNames = new string[4];
	public bool[] SafeTiles = new bool[16];

	// Use this for initialization
	void Start () {

		// Eggs[0] = 1;
		// Eggs[1] = 2;
		// Eggs[2] = 3;
		// Eggs[3] = 4;
		// Eggs[4] = 5;
		// Eggs[5] = 6;
		// Eggs[6] = 7;
		// Eggs[7] = 8;
		// Eggs[8] = 9;
		// Eggs[9] = 10;
		// Eggs[10] = 11;
		// Eggs[11] = 12;

		// print(Eggs[11]);

		// Jedi = new string[6];

		// Jedi[0] = "Obi Wan Kenobi";
		// Jedi[1] = "Mace Windu";
		// Jedi[2] = "Luke Skywalker";
		// Jedi[3] = "Yoda";
		// Jedi[4] = "Ahsoka Tano";
		// Jedi[5] = "Kit Fisto";

		// foreach(string item in Jedi){
		// 	print("Jedi Master " + item);
		// }

		// HOMEWORK

		PossibleLoot[0] = "1 money";
		PossibleLoot[1] = "5 money";
		PossibleLoot[2] = "Sword of Twigs";
		PossibleLoot[3] = "Some item that you already have way too much of";
		PossibleLoot[4] = "weak weapon";
		PossibleLoot[5] = "Bokoblin horn";

		PotatoSizes[0] = 1.0f;
		PotatoSizes[1] = 2.4f;
		PotatoSizes[2] = 2.3f;
		PotatoSizes[3] = 2.7f;
		PotatoSizes[4] = 0.7f;
		PotatoSizes[5] = 5.4f;
		PotatoSizes[6] = 4.5f;
		PotatoSizes[7] = 3.8f;

		PlayerNames[0] = "PoopSmite77";
		PlayerNames[1] = "U89N2_NSGI02NKLS";
		PlayerNames[2] = "yOURmOM";
		PlayerNames[3] = "marigo88";

		PlayerScores[0] = 6;
		PlayerScores[1] = 3;
		PlayerScores[2] = 2;
		PlayerScores[3] = 8;

		SafeTiles[0] = true;
		SafeTiles[1] = false;
		SafeTiles[2] = false;
		SafeTiles[3] = false;
		SafeTiles[4] = false;
		SafeTiles[5] = false;
		SafeTiles[6] = true;
		SafeTiles[7] = false;
		SafeTiles[8] = false;
		SafeTiles[9] = false;
		SafeTiles[10] = true;
		SafeTiles[11] = false;
		SafeTiles[12] = true;
		SafeTiles[13] = false;
		SafeTiles[14] = true;
		SafeTiles[15] = true;



		foreach(string Player in PlayerNames){
			print("Player "+Player+" joined the game");
		}
		foreach(int Score in PlayerScores){
			print("A Player scored "+Score);
		}

		string LootMessage = "Congratulations, you won the lottery and got:";
		foreach(string Loot in PossibleLoot){
			LootMessage += " " + Loot + ",";
		}
		print(LootMessage);

		float LargestPotatoSize = 0f;
		foreach(float Potato in PotatoSizes){
			if(Potato > LargestPotatoSize){
				LargestPotatoSize = Potato;
			}
		}
		print("Largest potato size is "+ LargestPotatoSize);

		foreach(bool Tile in SafeTiles){
			if(Tile){
				print("Tile is safe");
			}
			else{
				print("Avoid this Tile!");
			}
		}


	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
