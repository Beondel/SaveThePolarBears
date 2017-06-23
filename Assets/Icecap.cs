using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Icecap : MonoBehaviour {

	public int snowflakeCount;
	public int sunlightCount;
	public int sootCount;
	public int size;
	//public GameObject heatMeter;

	// Use this for initialization
	void Start () {
		GameObject.FindGameObjectWithTag ("button").gameObject.layer = 3;
		sootCount = 0;
		sunlightCount = 0;
		snowflakeCount = 0;
		size = 100;

		Physics2D.IgnoreCollision (GameObject.Find ("ice cap").GetComponent<Collider2D> (), GetComponent<Collider2D> ());
		Physics2D.IgnoreCollision (GameObject.Find ("panel").GetComponent<Collider2D> (), GetComponent<Collider2D> ());

		GetComponent<Rigidbody2D> ().freezeRotation = true;

		//heatMeter = GameObject.FindGameObjectWithTag ("heat").GetComponent<Heat_Meter> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnCollisionEnter2D(Collision2D other) {
		if (other.gameObject.tag == "snowflake") {
			//GameObject.FindGameObjectWithTag ("heat").GetComponent<Heat_Meter> ().snow ();
			if (size < 100) {
				size = size + 5;
			}
			Destroy (other.gameObject);
			snowflakeCount++;
			//GetComponent<Transform>().localScale = new Vector2((transform.localScale.x+1f*snowflakeCount*0.023f),(transform.localScale.y+1f*snowflakeCount*0.01f)); 
			//float newpos = (transform.position.y + 0.009f * -1f * snowflakeCount);
			//transform.position = new Vector2(transform.position.x, newpos);
		}
		if (other.gameObject.tag == "soot") {
			other.gameObject.GetComponent<particleMovement> ().enabled = false;
			other.gameObject.GetComponent<Rigidbody2D> ().velocity = new Vector2(0f,0f);
			sootCount++;
		}
		if (other.gameObject.tag == "sunlight") {
			//GameObject.FindGameObjectWithTag ("heat").GetComponent<Heat_Meter> ().sun ();
			size = size - 5;
			Destroy (other.gameObject);
			sunlightCount++;
			//GetComponent<Transform> ().localScale = new Vector2 ((transform.localScale.x + 1f * sunlightCount * -0.023f), (transform.localScale.y + 1f * sunlightCount * -0.01f)); 
			//float newpos = (transform.position.y + 0.009f * 1f * sunlightCount);
			//transform.position = new Vector2 (transform.position.x, newpos);
		}
	}

	public void specialContact() {
		//GameObject.FindGameObjectWithTag ("heat").GetComponent<Heat_Meter> ().special_sun ();
		size = size - 10;
		sunlightCount++;
		//GetComponent<Transform> ().localScale = new Vector2 ((transform.localScale.x + 3f * (sunlightCount+1) * -0.023f), (transform.localScale.y + 3f * (sunlightCount+1) * -0.01f)); 
		//float newpos = (transform.position.y + 0.009f * 3f * sunlightCount);
		//transform.position = new Vector2 (transform.position.x, newpos);
	}

	public void specialContact2(){
		snowflakeCount++;
		//GetComponent<Transform>().localScale = new Vector2((transform.localScale.x+1f*snowflakeCount*0.023f),(transform.localScale.y+1f*snowflakeCount*0.01f)); 
		//float newpos = (transform.position.y + 0.009f * -1f * snowflakeCount);
		//transform.position = new Vector2(transform.position.x, newpos);
	}
}
