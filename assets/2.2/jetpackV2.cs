using UnityEngine;
using System.Collections;

public class jetpackV2 : MonoBehaviour {

	public bool isGrounded = true;
	private float h ;

	public AudioClip engine_start;
	private AudioSource source;
	public Animator anim;
	private float volLowRange = .5f;
	private float volHighRange = 1.0f;



	// Use this for initialization
	void Start () {
		source = GetComponent<AudioSource>();
		anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		h = Input.GetAxis("Horizontal");
		if (Input.GetKeyDown ("space") && isGrounded == true) {
			print ("space key was pressed");
			gameObject.GetComponent<Rigidbody2D>().AddForce (new Vector2 (0, 3400));
			isGrounded = false;
			
		}
		if (Input.GetKey ("space") && isGrounded == false) {
			print ("repoussage");
			
			gameObject.GetComponent<Rigidbody2D>().AddForce (new Vector2 (0, 25));

		}
		if (Input.GetKeyUp ("space")) {
			
		}
		Vector3 velo = gameObject.GetComponent<Rigidbody2D>().velocity;
		velo.x = h * 10;
		gameObject.GetComponent<Rigidbody2D>().velocity = velo;

		float speed = Mathf.Abs (h);
		anim.SetFloat ("Speed", speed);
		anim.SetBool ("IsGrounded", isGrounded);
	}


	void FixedUpdate(){

	}







}
