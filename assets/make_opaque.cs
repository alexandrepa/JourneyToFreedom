using UnityEngine;
using System.Collections;

public class make_opaque : MonoBehaviour {

	private float opacity_degree = 0f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		opacity_degree += 0.01f;
		if (gameObject.GetComponent<SpriteRenderer> ().color.a < 1f) {
			gameObject.GetComponent<SpriteRenderer> ().color = new Color (gameObject.GetComponent<SpriteRenderer> ().color.b, gameObject.GetComponent<SpriteRenderer> ().color.g, gameObject.GetComponent<SpriteRenderer> ().color.b, opacity_degree);
		}
	}
}
