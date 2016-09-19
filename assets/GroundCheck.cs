using UnityEngine;
using System.Collections;

public class GroundCheck : MonoBehaviour {

	public jetpack jetpackscript;
	public deplacement deplacementscript;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D(Collision2D collision) {
		
		if (collision.gameObject.CompareTag("ground")) {
			jetpackscript.isGrounded = true;
			deplacementscript.isGrounded = true;
			print ("ccol");
			GetComponentInParent<Animator> ().SetBool ("IsGrounded", true);
			print ("collision sol");
		}

	}
}
