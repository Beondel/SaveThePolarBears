using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawners : MonoBehaviour {

	public GameObject[] enemies;
	public GameObject[] spawnerArray;
	public Vector3 spawnValues;
	public float spawnWait;
	public float spawnMostWait;
	public float spawnLeastWait;
	public int startWait;
	public bool started;

	int randEnemy;
	int randSpawner;

	void Start () {
		
	}


	void Update () {
		spawnWait = Random.Range (spawnLeastWait, spawnMostWait);
	}

	IEnumerator Spawner(){
		yield return new WaitForSeconds (startWait);

		while (true) {
			randEnemy = Random.Range (0, 3);
			randSpawner = Random.Range (0, 5);
			Vector3 spawnPosition = spawnerArray[randSpawner].transform.position;
			Instantiate (enemies[randEnemy], spawnPosition, gameObject.transform.rotation);
			yield return new WaitForSeconds (spawnWait);
		}
	}

	public void buttonPress(){
		GameObject.FindGameObjectWithTag ("instructions").transform.position = new Vector3 (1000f, 1000f);
		GameObject.FindGameObjectWithTag ("button").transform.position = new Vector3 (1000f, 1000f);
		StartCoroutine (Spawner());
		started = true;
	}
}