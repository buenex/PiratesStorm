using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class but : MonoBehaviour {
	public movePlayer player;
	public bool right;

	// Use this for initialization

	void OnMouseDown(){
		
		if (right) {
			player.andar = true;
			player.mirror = false;

		} else if (!right) {
			player.andar = true;
			player.mirror = true;
		}
	}
	void OnMouseUp(){
		
		player.andar = false;

	}
}
