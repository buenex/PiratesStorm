using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class angText : MonoBehaviour {
	public Text ang;
	public GameObject angP;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(angP.transform.rotation.z>0)
			ang.text ="ANG:"+ ((int)((angP.transform.rotation.z*0.9972222f) * 360-270)).ToString ();
		else if(angP.transform.rotation.z<0)
			ang.text ="ANG:"+ ((int)((angP.transform.rotation.z*-0.9972222f) * 360-270)).ToString ();
	}
}
