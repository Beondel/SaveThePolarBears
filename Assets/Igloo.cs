using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Igloo : MonoBehaviour {
	public Sprite[] iglooSprites;
	public int iceSize;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		iceSize = GameObject.FindGameObjectWithTag ("ice").GetComponent<Icecap> ().size;
		foreach (GameObject igloo in GameObject.FindGameObjectsWithTag("igloo")) {
			if (iceSize > 75) {
				igloo.GetComponent<SpriteRenderer> ().sprite = iglooSprites [0];
			} else if (iceSize <= 75 && iceSize > 50) {
				igloo.GetComponent<SpriteRenderer> ().sprite = iglooSprites [1];
			} else if (iceSize <= 50 && iceSize > 25) {
				igloo.GetComponent<SpriteRenderer> ().sprite = iglooSprites [2];
			} else if (iceSize <= 25) {
				igloo.GetComponent<SpriteRenderer> ().sprite = iglooSprites [3];
			}
		}
	}
}
