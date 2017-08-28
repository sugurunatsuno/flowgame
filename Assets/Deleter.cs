using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Deleter : MonoBehaviour {

	public static int _score;
	public Text _scoreText;

	// Use this for initialization
	void Start () {
		_score = 0;
		_scoreText.text = "Score: " + _score;

	}
	
	// Update is called once per frame
	void Update () {
		_scoreText.text = "Score: " + _score;
	}

	void OnCollisionEnter(Collision other){
		if (other.gameObject.tag == "Onion") {
			Destroy (other.gameObject, 1);
			_score = 0;
		}

		if (other.gameObject.tag == "Tomato") {
			Destroy (other.gameObject, 1);
			_score += 100;
		}

	}

}
