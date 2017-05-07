using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particleMovement : MonoBehaviour {
	private float speed;

	// Use this for initialization
	void Start () {
		speed = Random.Range (1.0f, 2.0f);
	}

	// Update is called once per frame
	void Update () {
		transform.Translate (Vector3.down * speed * Time.deltaTime);
	}
}
