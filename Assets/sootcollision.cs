using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sootcollision : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void onCollisionEnter2D(Collision2D other){
		if (other.gameObject.tag == "soot") {
			Debug.Log ("soot");
			Destroy (this.gameObject);
		}
		if (other.gameObject.tag == "sunlight") {
			Debug.Log ("sunlight");
			Destroy (other.gameObject);
			GameObject.Find ("ice cap").GetComponent<Icecap> ().specialContact ();
		}
		if (other.gameObject.tag == "snowflake") {
			Debug.Log ("snowflake");
			Destroy (other.gameObject);
			GameObject.Find ("ice cap").GetComponent<Icecap> ().specialContact2 ();
		}
	}
}
