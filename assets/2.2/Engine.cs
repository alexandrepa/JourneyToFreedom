using UnityEngine;
using System.Collections;

public class Engine : MonoBehaviour {
	private AudioSource source;
	public AudioClip engine;

	// Use this for initialization
	void Start () {
		source = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (!source.isPlaying) {
			//float vol = gameObject.GetComponentInParent<Rigidbody2D>().velocity.magnitude;
			//source.clip = engine; 
			source.PlayOneShot(engine);
		}
	
	}
}
