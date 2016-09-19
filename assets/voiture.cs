using UnityEngine;
using System.Collections;

public class voiture : MonoBehaviour {
	public GameObject player;
	bool test = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D(Collision2D collision){
		
		if (collision.gameObject.tag == "player") {
			if (!test) {
				gameObject.GetComponent<ConstantForce2D> ().force = new Vector2 (100, 0);
				collision.gameObject.GetComponent<deplacement> ().enabled = false;
				test = true;
			}
	
		}
		if (collision.gameObject.name == "jeu_societe") {
			player.GetComponent<deplacement> ().enabled = true;
			gameObject.GetComponent<Rigidbody2D> ().isKinematic = true;
			gameObject.GetComponent<PolygonCollider2D> ().enabled = true;
			gameObject.GetComponent<ConstantForce2D> ().force = new Vector2(0,0);
			gameObject.GetComponent<Rigidbody2D> ().velocity = new Vector2 (0, 0);
			gameObject.GetComponent<Rigidbody2D> ().gravityScale = 0;
			gameObject.GetComponent<PolygonCollider2D> ().enabled = true;
			/*
			player.GetComponent<Rigidbody2D> ().AddForce (new Vector2(0, 2800));

			player.GetComponent<Rigidbody2D> ().AddForce (new Vector2(2000, 0));
			*/




		}
	}
}
