using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public int speed = 5;
	public bool left = false;
	public bool right = false;
	public bool down = false;
	public bool up = false;


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
			up = true;
			down = false;
			right = false;
			left = false;
		} else if (Input.GetKey (KeyCode.S)) {
			transform.Translate (Vector3.down * speed * Time.deltaTime);
			down = true;
			up = false;
			right = false;
			left = false;
		} else if (Input.GetKey (KeyCode.A)) {
			transform.Translate (Vector3.left * speed * Time.deltaTime);
			left = true;
			down = false;
			right = false;
			up = false;
		} else if (Input.GetKey (KeyCode.D)) {
			transform.Translate (Vector3.right * speed * Time.deltaTime);
			right = true;
			left = false;
			down = false;
			up = false;
		} else {
			left = false;
			right = false;
			down = false;
			up = false;
		}
	}
}
