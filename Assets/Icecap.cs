using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Icecap : MonoBehaviour {

	public int snowflakeCount;
	public int sunlightCount;
	public int sootCount;

	// Use this for initialization
	void Start () {
		sootCount = 0;
		sunlightCount = 0;
		snowflakeCount = 0;

		Physics2D.IgnoreCollision (GameObject.Find ("ice cap").GetComponent<Collider2D> (), GetComponent<Collider2D> ());
		Physics2D.IgnoreCollision (GameObject.Find ("panel").GetComponent<Collider2D> (), GetComponent<Collider2D> ());

		GetComponent<Rigidbody2D> ().freezeRotation = true;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D(Collision2D other) {
		if (other.gameObject.tag == "snowflake") {
			Destroy (other.gameObject);
			snowflakeCount++;
			GetComponent<Transform>().localScale = new Vector2((transform.localScale.x+5f*snowflakeCount*0.023f),(transform.localScale.y+5f*snowflakeCount*0.01f)); 
			float newpos = (transform.position.y + 0.009f * -5f * snowflakeCount);
			transform.position = new Vector2(transform.position.x, newpos);
		}
		if (other.gameObject.tag == "soot") {
			other.gameObject.GetComponent<particleMovement> ().enabled = false;
			other.gameObject.GetComponent<Rigidbody2D> ().velocity = new Vector2(0f,0f);
			//other.gameObject.transform.Translate (new Vector3(other.gameObject.transform.position.x, other.gameObject.transform.position.y));
			sootCount++;
		}
		if (other.gameObject.tag == "sunlight") {
			Destroy (other.gameObject);
			sunlightCount++;
			if (sootCount == 0) {
				GetComponent<Transform> ().localScale = new Vector2 ((transform.localScale.x + 5f * sunlightCount * -0.023f), (transform.localScale.y + 5f * sunlightCount * -0.01f)); 
				float newpos = (transform.position.y + 0.009f * 5f * snowflakeCount);
				transform.position = new Vector2 (transform.position.x, newpos);
			} else {
				GetComponent<Transform> ().localScale = new Vector2 ((transform.localScale.x + 15f * sunlightCount * -0.023f), (transform.localScale.y + 15f * sunlightCount * -0.01f)); 
				float newpos = (transform.position.y + 0.009f * 15f * snowflakeCount);
				transform.position = new Vector2 (transform.position.x, newpos);
			}
		}
	}
}
