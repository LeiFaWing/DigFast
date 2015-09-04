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

		if (Input.GetKey (KeyCode.W)) {
			transform.Translate (Vector3.up * speed * Time.deltaTime);
			up = true;
		} else if (Input.GetKey (KeyCode.S)) {
			transform.Translate (Vector3.down * speed * Time.deltaTime);
			down = true;
		} else if (Input.GetKey (KeyCode.A)) {
			transform.Translate (Vector3.left * speed * Time.deltaTime);
			left = true;
		} else if (Input.GetKey (KeyCode.D)) {
			transform.Translate (Vector3.right * speed * Time.deltaTime);
			right = true;
		} else {
			left = false;
			right = false;
			down = false;
			up = false;
		}
	}
}
