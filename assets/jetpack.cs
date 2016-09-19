using UnityEngine;
using System.Collections;

public class jetpack : MonoBehaviour {

	public bool isGrounded = true;
	private float h ;

	public AudioClip engine_start;
	private AudioSource source;
	public Animator anim;
	private float volLowRange = .5f;
	private float volHighRange = 1.0f;
	public GameObject jet;
	public bool faceRight = true;



	// Use this for initialization
	void Start () {
		source = GetComponent<AudioSource>();
		anim = GetComponent<Animator>();

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
		if (Input.GetKeyDown ("space") && isGrounded == true) {
			print ("space key was pressed");
			gameObject.GetComponent<Rigidbody2D>().AddForce (new Vector2 (0, 3400));
			isGrounded = false;
			anim.SetBool ("Jumped", true);
		}
		if (Input.GetKey ("space") && isGrounded == false) {
			print ("repoussage");
			anim.SetBool ("Jumped", true);
			gameObject.GetComponent<Rigidbody2D>().AddForce (new Vector2 (0, 25));

		}
		if (Input.GetKeyUp ("space")) {
			anim.SetBool ("Jumped", false);
		}
		Vector3 velo = gameObject.GetComponent<Rigidbody2D>().velocity;
		velo.x = h * 10;
		gameObject.GetComponent<Rigidbody2D>().velocity = velo;

		float speed = Mathf.Abs (h);
		print (speed);
		print (isGrounded);
		anim.SetFloat ("Speed", speed);
		anim.SetBool ("IsGrounded", isGrounded);
	}
	void Flip(){
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;

	}

	void FixedUpdate(){
		jet.SetActive (true);
	}







}
