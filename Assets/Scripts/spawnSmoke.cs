using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnSmoke : MonoBehaviour {
	public GameObject smoke;
	// Use this for initialization
	IEnumerator Start () {
		WaitForSeconds delay = new WaitForSeconds(0.05f);
		while(true){
			Instantiate(smoke,this.transform.position,this.transform.rotation);
			yield return delay;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	 
}
