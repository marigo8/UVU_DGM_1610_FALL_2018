using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCutscene : MonoBehaviour {

	public CameraFollow MainCamera;
	public Transform Target;
	public Transform PC;

	public float Duration;
	public bool Active;

	// Use this for initialization
	void Start () {
		Active = true;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter2D(Collider2D Other){
		if(Other.name == "PC" && Active){
			Active = false;
			StartCoroutine("FollowTarget");
		}
	}
	public IEnumerator FollowTarget(){
		print("C U T S C E N E");
		MainCamera.Target = Target;
		yield return new WaitForSecondsRealtime(Duration);
		MainCamera.Target = PC;
	}
}
