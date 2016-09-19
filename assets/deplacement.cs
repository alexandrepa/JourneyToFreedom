using UnityEngine;
using System.Collections;

public class deplacement : MonoBehaviour {

	public bool isGrounded = true;
	public bool faceRight = true;
	private float h ;
	public GameObject jet;


	public AudioClip engine_start;
	private AudioSource source;
	public Animator anim;
	private float volLowRange = .5f;
	private float volHighRange = 1.0f;

	public AudioSource audio1;
	public AudioSource audio2;
	public AudioSource audio3;


	// Use this for initialization
	void Start () {
		

		AudioSource[] AudioSource = GetComponents<AudioSource>();
		audio1 = AudioSource [0];
		audio2 = AudioSource [1];
		audio3 = AudioSource [2];
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
			gameObject.GetComponent<Rigidbody2D>().AddForce (new Vector2 (0, 2800));
			isGrounded = false;
			anim.SetBool ("Jumped", true);
			audio2.Play ();

		}

		if (Input.GetKeyUp ("space")) {
			anim.SetBool ("Jumped", false);
		}
		if (isGrounded) {
			Vector3 velo = gameObject.GetComponent<Rigidbody2D>().velocity;
			velo.x = h * 8;
			gameObject.GetComponent<Rigidbody2D>().velocity = velo;
		} else {
			gameObject.GetComponent<Rigidbody2D> ().AddForce (new Vector2 (h * 20, 0));
		}
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
		if (isGrounded && !audio3.isPlaying) {
			audio3.Play ();
		}


	}
	void FixedUpdate(){
		jet.SetActive(false);
	}
	}

