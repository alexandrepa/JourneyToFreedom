using UnityEngine;
using System.Collections;

public class agrapheuse : MonoBehaviour {
	public agraphe_fix ag;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D (Collision2D collision){

		if (collision.gameObject.name == "agfreuse_tete") {
			collision.gameObject.GetComponent<Rigidbody2D>().AddForce (new Vector2 (10000, 0));
			ag.test=true;

		}

	}
}
