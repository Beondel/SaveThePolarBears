using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Heat_Meter : MonoBehaviour {
	
	public int iceCapSize;
	public Sprite[] sprites;
	public Text score;

	void Start () {
		
	}

	void Update () {
		if (GameObject.FindGameObjectWithTag ("Respawn").GetComponent<spawners> ().started) {
			iceCapSize = GameObject.FindGameObjectWithTag ("ice").GetComponent<Icecap> ().size;
			if (iceCapSize >= 0 && iceCapSize <= 100) {
				Change ();
			}
		}
	}

	void Change () {
		int n = (int)(((100 - iceCapSize) / 25) * 10);
		//GameObject.FindGameObjectWithTag("heat").GetComponent<SpriteRenderer>().sprite = sprites[n];
		score.text = iceCapSize.ToString();
	}


	/*
	public void sun(){
		transform.localScale = (new Vector3 (0, 1, 0));
	}

	public void snow(){
		transform.localScale = (new Vector3 (0, -1, 0));
	}

	public void special_sun(){
		transform.localScale = (new Vector3 (0, 3, 0));
	}
	*/
	public void buttonPressed(){
		iceCapSize = GameObject.FindGameObjectWithTag ("ice").GetComponent<Icecap> ().size;
		//sprites = Resources.LoadAll<Sprite>("heatMeters");
		score.text = iceCapSize.ToString();
	}
}
