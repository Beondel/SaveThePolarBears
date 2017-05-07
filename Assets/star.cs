using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class star : MonoBehaviour {
	private static int speed;

	// Use this for initialization
	void Start () {
		speed = 1;
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector3.down * speed * Time.deltaTime);
	}
}

