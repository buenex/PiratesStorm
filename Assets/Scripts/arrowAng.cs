using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrowAng : MonoBehaviour {
	public float angle;
	public bool up,able;
	public GameObject ammo;
	public GameObject target;
	public float minAng,maxAng,minAngMir,maxAngMir;
	// Use this for initialization
	void Start () {
		maxAng = 0.95f;
		minAng = 0.6f;
		maxAngMir = -0.95f;
		minAngMir = -0.6f;
	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log ( "Able: "+able+"  Up= "+up+"  Mirror="+target.GetComponent<movePlayer>().mirror+"  MinAngMir="+minAngMir+"  MaxAngMir="+maxAngMir+"   Rot Z = "+transform.rotation.z);
		if (able && up && !target.GetComponent<movePlayer>().mirror && maxAng>transform.rotation.z) {
			transform.Rotate ( new Vector3 (0, 0, angle-0.9972222f));
			transform.RotateAround (target.transform.position, new Vector3 (0, 0, 1), angle);
			//Debug.Log ("UP = " + transform.rotation);
		} else if (able && !up && !target.GetComponent<movePlayer>().mirror && minAng < transform.rotation.z) {
			transform.Rotate(new Vector3 (0, 0, -angle+0.9972222f));
			transform.RotateAround (target.transform.position, new Vector3 (0, 0, 1), -angle);
			//Debug.Log ("DOWN = " + transform.rotation);
		}else if (able && up && target.GetComponent<movePlayer>().mirror && maxAngMir < transform.rotation.z) {
			transform.Rotate ( new Vector3 (0, 0, -angle+0.9972222f));
			transform.RotateAround (target.transform.position, new Vector3 (0, 0, 1), -angle);
			//Debug.Log ("UP = " + transform.rotation);
		} else if (able && !up && target.GetComponent<movePlayer>().mirror && minAngMir > transform.rotation.z) {
			transform.Rotate(new Vector3 (0, 0, angle-0.9972222f));
			transform.RotateAround (target.transform.position, new Vector3 (0, 0, 1), +angle);
			//Debug.Log ("DOWN = " + transform.rotation);
		}
		/*if (Input.GetMouseButtonDown(1)) {
			
			Instantiate (ammo, this.transform.position, this.transform.rotation);
		}*/
	}
}
