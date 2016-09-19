using UnityEngine;
using System.Collections;

public class go_back : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	 void OnTriggerEnter2D(Collider2D Collision){
		if (Collision.gameObject.name == "player") {
			Collision.gameObject.GetComponent<deplacement_eau> ().enabled = false;
		}


	}
}
