using UnityEngine;
using System.Collections;

public class pick_up_spare_part : MonoBehaviour {

	public GameObject top;
	public GameObject mid;
	public GameObject bot;
	public GameObject croix;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D collision){

		if (collision.gameObject.name == "player") {


			if (gameObject.name == "haut_fusee") {
				
				top.SetActive(true);
			} else if (gameObject.name == "milieu_fusee") {
				mid.SetActive(true);
			} else if (gameObject.name == "bas_fusee") {
				bot.SetActive(true);
			}
			croix.SetActive (true);


			gameObject.SetActive(false);
		}

	}
}
