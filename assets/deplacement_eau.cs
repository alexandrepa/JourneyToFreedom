using UnityEngine;
using System.Collections;

public class deplacement_eau : MonoBehaviour {

	public bool isGrounded = true;
	public bool faceRight = true;
	private float h ;
	public GameObject jet;

	// Use this for initialization
	void Start () {
		
	}
	void OnEnable(){

		Vector3 theScale = transform.localScale;
		if (theScale.x >= 0) {
			faceRight = true;
		} else {
			faceRight = false;
		}
	}

	// Update is called once per frame
	void Update () {
		h = Input.GetAxis("Horizontal");
		if (h < 0 && faceRight) {
			faceRight = false;
			Flip ();

		}
		if (h > 0 && !faceRight) {
			faceRight = true;
			Flip ();

		}
		if (Input.GetKeyDown ("space")) {
			isGrounded=false;
			gameObject.GetComponent<Rigidbody2D>().AddForce (new Vector2 (0, 1000));
		}

		if (Input.GetKey ("space") && isGrounded == false) {
			print ("repoussage");
			gameObject.GetComponent<Rigidbody2D>().AddForce (new Vector2 (0, 70));

		}
		if (Input.GetKeyUp ("space")) {

		}
		Vector3 velo = gameObject.GetComponent<Rigidbody2D>().velocity;
		velo.x = h * 10;
		gameObject.GetComponent<Rigidbody2D>().velocity = velo;

	}
	void Flip(){
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}
	void FixedUpdate(){
		jet.SetActive (false);
	}
}
