using UnityEngine;
using System.Collections;

public class feu_6 : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyUp ("space")) {
			gameObject.GetComponent<SpriteRenderer> ().enabled = false;
		}
	}
}
