using UnityEngine;
using System.Collections;

public class fusee_end : MonoBehaviour {
	public bool move = false;

	public GameObject bot;
	public GameObject mid;
	public GameObject top;
	public GameObject mid_new;
	private GameObject player;
	public GameObject camera;

	public Animator anim;
	public AudioSource source;
	public bool  i = true;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
		source = GetComponent<AudioSource> ();
	}

	// Update is called once per frame
	void Update () {
		
		if (move == true) {
			Vector2 newPos = gameObject.transform.position;
			gameObject.SetActive (true);
			newPos.y += 0.1f;
			anim.SetBool ("go", true);
			if (i){
				source.Play ();
				i = false;
			}


			/*if (newPos.x  <-5.2f && newPos.x  >-5.3f) {
				move = false;

			}*/
			gameObject.GetComponent<Rigidbody2D> ().MovePosition (newPos);
		}
	}
	void OnTriggerEnter2D(Collider2D collider){

		if (collider.gameObject.name == "player" && bot.active ==true && mid.active==true && top.active==true) {
			Invoke ("setMove", 3);

			player = collider.gameObject;
			Invoke ("disable_player", 1);

		}

	}

	void setMove(){
		
		move = true;
	}

	void disable_player(){
		player.SetActive (false);
		mid.SetActive (false);
		mid_new.SetActive (true);
		camera.GetComponent<CameraFollow> ().enabled = false;
		camera.GetComponent<camera_end> ().enabled = true;
	}

}
