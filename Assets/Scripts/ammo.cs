using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ammo : MonoBehaviour {
	Vector3 a,b;
	public float speed;
	 GameObject cam,ui;


	// Use this for initialization
	void Start () {
		
		ui=GameObject.FindGameObjectWithTag ("ui");
		cam = GameObject.FindGameObjectWithTag ("MainCamera");
		a = new Vector3 (0, -speed, 0);

		cam.GetComponent<cameraControl> ().enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		ui.SetActive (false);
		cam.transform.position = new Vector3 (this.transform.position.x, cam.transform.position.y, cam.transform.position.z);
			
			transform.Translate (a);




	}
	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.tag == "floor") {
			Destroy (this.gameObject);
			cam.transform.position = new Vector3(GameObject.FindGameObjectWithTag ("Player").transform.position.x,cam.transform.position.y,cam.transform.position.z);
			ui.SetActive (true);
			cam.GetComponent<cameraControl> ().enabled = true;
		}
	}
}
