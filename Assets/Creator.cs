using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creator : MonoBehaviour {

	public GameObject[] prefabs;
	public float p;
	public float late;
	private float lapped;
	public Vector3 pos;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		lapped += Time.deltaTime;
		if (lapped > late) {

			float inst = Random.value;
			if (inst < p) {
				Instantiate (prefabs [0], transform.position + pos , Quaternion.identity);
			} else {
				Instantiate (prefabs [1], transform.position + pos , Quaternion.identity);
			}

			lapped = 0.0f;
		}
	}
}
