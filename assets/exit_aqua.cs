using UnityEngine;
using System.Collections;

public class exit_aqua : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D(Collision2D collision){

		if (collision.gameObject.tag == "player") {

			print ("collision avec le player");
			collision.gameObject.GetComponent<deplacement_eau> ().enabled = false;

			collision.gameObject.GetComponent<jetpack> ().enabled = false;
			collision.gameObject.GetComponent<deplacement> ().enabled = true;
		}

	}
}
