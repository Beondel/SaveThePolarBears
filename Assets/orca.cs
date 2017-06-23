using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class orca : MonoBehaviour {

	public Sprite[] orca_frames;

	// Use this for initialization
	void Start () {
		orca_frames = new Sprite[53];
		for (int i = 0; i < 53; i++) {
			orca_frames [i] = Resources.Load<Sprite> ("orca animation " + (50000 + i));
		}
	}

	// Update is called once per frame
	void Update () {
		runAnimation (Time.frameCount);
	}

	void runAnimation(int time) {
		GetComponent<SpriteRenderer> ().sprite = orca_frames[time % 53];
	}
}
