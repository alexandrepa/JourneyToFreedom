using UnityEngine;
using System.Collections;

public class itemBox : MonoBehaviour {

	public GameObject Player;
	public GameObject jetpack;
	public GameObject check;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter2D(Collider2D collision){
		print ("itembox");
		if (collision.gameObject.tag == Player.tag) {
			deplacement dep = collision.gameObject.GetComponent<deplacement> ();
			dep.enabled = !dep.enabled;

			jetpack jet = collision.gameObject.GetComponent<jetpack> ();
			jet.enabled = !jet.enabled;


			if (gameObject.name == "jetpack_item") {
				gameObject.SetActive (false);
				check.SetActive (true);

			} 

			if (gameObject.name == "checkpoint_fin_jetpack") {
				gameObject.SetActive (false);
				jetpack.SetActive (true);

			} 



		}
	}

}
