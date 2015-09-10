using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public int speed = 5;
	public string direction = "neutral";

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		playerMovement ();
	}

	void playerMovement() {
		if (Input.GetKey (KeyCode.W)) {
			transform.Translate (Vector3.up * speed * Time.deltaTime);
			direction = "up";
		} else if (Input.GetKey (KeyCode.S)) {
			transform.Translate (Vector3.down * speed * Time.deltaTime);
			direction = "down";
		} else if (Input.GetKey (KeyCode.A)) {
			transform.Translate (Vector3.left * speed * Time.deltaTime);
			direction = "left";
		} else if (Input.GetKey (KeyCode.D)) {
			transform.Translate (Vector3.right * speed * Time.deltaTime);
			direction = "right";
		} else {
			direction = "neutral";
		}
	}
}
