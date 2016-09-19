using UnityEngine;
using System.Collections;

public class agraphe_fix : MonoBehaviour {
	public bool test;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void FixedUpdate(){


		if ( Vector3.SqrMagnitude(gameObject.transform.position - new Vector3(-54.4f,19.4f,0))<0.1 && test){
			gameObject.GetComponent<Rigidbody2D> ().freezeRotation = true;
		}
	}
	void OnCollisionEnter2D (Collision2D collision){
		
		if (collision.gameObject.CompareTag("player")) {
			print ("player agraph");
			test = false;
			gameObject.GetComponent<Rigidbody2D> ().freezeRotation = false;

		}

	}
}
