using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class title : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void ToGame(){
		Application.LoadLevel ("flow");
	}

	public void ToTitle(){
		Application.LoadLevel ("title");
	}

	public void Tweet(){
		int score = Deleter._score;
		Application.OpenURL("http://twitter.com/intent/tweet?text=" + WWW.EscapeURL("スコアは"+score+"でした #スイカを取り除け"));
	}
}
