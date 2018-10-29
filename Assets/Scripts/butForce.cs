using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class butForce : MonoBehaviour {
	public Image img,imgRef,stam;
	public fill fl;
	public ammo am;
	public GameObject muni;
	public GameObject reference;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnMouseDown(){
		

		fl.able = true;

	}
	void OnMouseUp(){
		fl.able = false;
		am.speed = img.fillAmount/2;
		Instantiate (muni,reference.transform.position,reference.transform.rotation);

		imgRef.fillAmount = img.fillAmount;
		img.fillAmount = 0;
		stam.fillAmount = 1;
	}
}
