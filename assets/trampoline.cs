using UnityEngine;
using System.Collections;

public class trampoline : MonoBehaviour {

	bool willBounce = false;
	float bounceHeight = 100;
	public Transform Player;

	// Use this for initialization
	void Start () 
	{


	}

	// Update is called once per frame
	void Update () 
	{

		if (willBounce) 
		{
			
			Vector3 velo = Player.GetComponent<Rigidbody2D> ().velocity;
			velo.y = 0;
			Player.GetComponent<Rigidbody2D>().velocity=velo;
			Player.GetComponent<Rigidbody2D>().AddForce (new Vector2(0, bounceHeight), ForceMode2D.Impulse);
			willBounce = false;
		}
	}

	void OnCollisionEnter2D (Collision2D other)
	{

		if (other.gameObject.name == "player")
		{
			print ("trampo");
			willBounce = true;
		}

	}
}
