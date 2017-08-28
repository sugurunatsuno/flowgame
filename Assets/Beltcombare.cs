using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beltcombare : MonoBehaviour {

	public Vector3 direction;
	public float power;
	public Material mater;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionStay(Collision other){
		Rigidbody rb;
		Vector3 dir;

		if (rb = other.gameObject.GetComponent<Rigidbody> ()) {
			dir = transform.TransformDirection (direction);
			rb.MovePosition (other.transform.position + dir * power * Time.fixedDeltaTime);
		}
	}

	void OnCollisionExit(Collision other){
		Rigidbody rb;
		if (rb = other.gameObject.GetComponent<Rigidbody> ()) {
			rb.AddForce (direction * power, ForceMode.Impulse);

		}
	}

	void FixedUpdate(){
		if (mater) {
			mater.mainTextureOffset += Vector2.right * power / 4 * Time.fixedDeltaTime;
		}
	}
}
