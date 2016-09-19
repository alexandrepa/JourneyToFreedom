using UnityEngine;
using System.Collections;

public class souris : MonoBehaviour {
	public GameObject plat_souris_player;
	public GameObject etoile1;

	public bool check = false;
	private bool move = false;
	public SpriteRenderer green;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (move == true) {
			Vector2 newPos = plat_souris_player.transform.position;
			plat_souris_player.SetActive (true);
			newPos.x += 0.1f;

			if (newPos.x  <-5.2f && newPos.x  >-5.3f) {
				move = false;
				etoile1.SetActive (true);
			}
			plat_souris_player.GetComponent<Rigidbody2D> ().MovePosition (newPos);
		}
	}

	void OnTriggerEnter2D (Collider2D collision) {
		gameObject.GetComponent<SpriteRenderer> ().enabled = true;



		if (check == false) {
			move = true;
			GetComponent<AudioSource> ().Play ();
		}

			check = true;

	}
}
