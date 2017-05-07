using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	private float speed;
	// Use this for initialization
	void Start () {
		speed = 3;
		GetComponent<Rigidbody2D> ().freezeRotation = true;
		Physics2D.IgnoreCollision (GameObject.FindGameObjectWithTag ("ocean").GetComponent<Collider2D> (), GetComponent<Collider2D> ());
	}
	
	// Update is called once per frame
	void Update () {
		float axisX = Input.GetAxis("Horizontal");
		float axisY = Input.GetAxis("Vertical");
		transform.Translate(new Vector3(axisX, axisY) * Time.deltaTime * speed);
	}

	void OnCollisionEnter2D(Collision2D other) {
		Destroy (other.gameObject);
	}
}
