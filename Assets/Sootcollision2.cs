using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sootcollision2 : MonoBehaviour {

	public bool onIce;

	// Use this for initialization
	void Start () {
		onIce = false;
	}

	// Update is called once per frame
	void Update () {

	}

	void OnCollisionEnter2D(Collision2D other){
		if (other.gameObject.tag == "ice") {
			onIce = true;
		}
		if (other.gameObject.tag == "soot" && other.gameObject.GetComponent<Sootcollision2>().onIce){
			Destroy (this.gameObject);
		}
		if (other.gameObject.tag == "sunlight") {
			Destroy (other.gameObject);
			GameObject.Find ("ice cap").GetComponent<Icecap> ().specialContact ();
		}
		if (other.gameObject.tag == "snowflake") {
			Destroy (other.gameObject);
			GameObject.Find ("ice cap").GetComponent<Icecap> ().specialContact2 ();
		}
	}
}
