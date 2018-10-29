using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class movePlayer : MonoBehaviour {
	public float speed;
	public bool andar,mirror;
	Vector3 scale,scaleMirror;
	public Image fill;

	// Use this for initialization
	void Start () {
		andar = false;
		mirror = false;
		scale = transform.localScale;
		scaleMirror = new Vector3 (-scale.x, scale.y, scale.z);
	}
	
	// Update is called once per frame
	void Update () {
		if (andar	&&	!mirror) {
			transform.localScale = scale;
			if (fill.fillAmount > 0) {
				this.transform.position += new Vector3 (speed, 0, 0);
				fill.fillAmount -= 0.01f;
			}
		}
		if (andar	&&	mirror) {
			transform.localScale = scaleMirror;
			if (fill.fillAmount > 0) {
				this.transform.position += new Vector3 (-speed, 0, 0);
				fill.fillAmount -= 0.01f;
			}
		}
	}
}
