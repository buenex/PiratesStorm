using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fill : MonoBehaviour {
	public bool able;
	bool right;
	Image img;
	float fillSpeed=0.005f;
	// Use this for initialization
	void Start () {
		img = GetComponent<Image> ();
		able = false;
		right = true;
	}
	
	// Update is called once per frame
	void Update () {
		if (img.fillAmount == 0)
			right = true;
		else if (img.fillAmount == 1)
			right = false;
		if (able) {
			if(right)
				img.fillAmount +=fillSpeed;
			else if(!right)
				img.fillAmount -=fillSpeed;
		}
	}
}
