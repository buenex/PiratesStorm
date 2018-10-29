using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class smoke : MonoBehaviour {
	SpriteRenderer spr;
	Vector3 scale;
	Color cor;
	// Use this for initialization
	void Start () {
		cor = new Color (0, 0, 0, 0.02f);
		scale = new Vector3 (0.2f, 0.2f, 0);
		spr = GetComponent<SpriteRenderer> ();
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.localScale += scale;
		spr.color -= cor;
		if (spr.color.a < 0.3f) {
			Destroy (gameObject);
		}
	}
}
