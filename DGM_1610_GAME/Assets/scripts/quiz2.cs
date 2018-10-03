using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quiz2 : MonoBehaviour {

	// Two Variables
	public int Var1;
	public int Var2;
	private int Total;

	public int Sum (int Num1, int Num2) {
		Total = Num1+Num2;
		print(Total);
		return Total;
	}

	// Use this for initialization
	void Start () {
		Sum(Var1,Var2);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
