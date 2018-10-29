using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraControl : MonoBehaviour {
	public GameObject player;
	// Use this for initialization
	void Start () {
		this.transform.position =new Vector3( player.transform.position.x,this.transform.position.y,-10);
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.position =new Vector3( player.transform.position.x,this.transform.position.y,-10);
	}
}
