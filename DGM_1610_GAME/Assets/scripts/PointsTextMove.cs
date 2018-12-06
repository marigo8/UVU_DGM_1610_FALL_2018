using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointsTextMove : MonoBehaviour {

	public float LifeTime;
	public float Velocity;
	public Vector3 Position;

	// Use this for initialization
	void Start () {
		StartCoroutine("MoveUp");
	}
	
	// Update is called once per frame
	void Update () {
		Position = GetComponent<Transform>().position;
		Position = new Vector3(Position.x,Position.y+Velocity,Position.z);
		GetComponent<Transform>().position = Position;
	}

	public IEnumerator MoveUp(){
		yield return new WaitForSeconds(LifeTime);
		Destroy(gameObject);
	}
}