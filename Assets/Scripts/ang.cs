using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ang : MonoBehaviour {
	public arrowAng scrip;
	public bool up;
	public movePlayer mp;
	public GameObject gm;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	//public bool right;
	// Use this for initialization

	void OnMouseDown(){
		
		if (up  ) {
			scrip.able = true;
			scrip.up = true;

		} else if (!up ) {
			scrip.able = true;
			scrip.up = false;
		}
	}
	void OnMouseUp(){
		scrip.able = false;


	}
}
