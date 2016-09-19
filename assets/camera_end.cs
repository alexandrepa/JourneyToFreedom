using UnityEngine;
using System.Collections;

public class camera_end : MonoBehaviour {

	public GameObject fond;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		// By default the target x and y coordinates of the camera are it's current x and y coordinates.

	}

	void FixedUpdate(){
		float targetX = transform.position.x;
		float targetY = transform.position.y;

		transform.position = new Vector3(0, 0, transform.position.z);
		if (gameObject.GetComponent<Camera> ().orthographicSize < 45) {
			gameObject.GetComponent<Camera> ().orthographicSize += 0.33f;
		} else if (gameObject.GetComponent<Camera> ().orthographicSize >= 45){
			fond.GetComponent<make_opaque> ().enabled = true;
		}
	}
		

}
