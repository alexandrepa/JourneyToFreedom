using UnityEngine;
using System.Collections;

public class aqua_jump : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D (Collider2D collider){
		if (collider.gameObject.name == "player") {
			print ("aqua");
			collider.gameObject.GetComponent<Rigidbody2D> ().AddForce (new Vector2 (0, 5000));
		}
	}
}
