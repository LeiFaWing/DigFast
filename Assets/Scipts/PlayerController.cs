using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public int speed = 5;
	public string direction = "neutral";

	Vector3 movementDirection;
//	public float gridX;
//	public float gridY;
	public float leftWall;
	public float rightWall;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		playerMovement ();
	}

	void playerMovement() {
		if (Input.GetKey (KeyCode.W)) {
			//transform.Translate (Vector3.up * speed * Time.deltaTime);
			direction = "up";
		} else if (Input.GetKey (KeyCode.S)) {
//			movementDirection = new Vector3(0, 1, 0);
//			Vector3 newPos = transform.position + movementDirection;
//			newPos = new Vector3(Mathf.Round(newPos.x/gridX)*gridX,
//			                 Mathf.Round(newPos.y/gridY)*gridY);

            transform.Translate (Vector3.down * speed * Time.deltaTime);
			direction = "down";
		} else if (Input.GetKey (KeyCode.A) && transform.position.x >= leftWall) {
//			movementDirection = new Vector3(-1, 0, 0);
//			Vector3 newPos = transform.position + movementDirection;
//			newPos = new Vector3(Mathf.Round(newPos.x/gridX)*gridX,
//			                     Mathf.Round(newPos.y/gridY)*gridY);
			transform.Translate (Vector3.left * speed * Time.deltaTime);
			direction = "left";
		} else if (Input.GetKey (KeyCode.D) && transform.position.x <= rightWall) {
//			movementDirection = new Vector3(1, 0, 0);
//			Vector3 newPos = transform.position + movementDirection;
//			newPos = new Vector3(Mathf.Round(newPos.x/gridX)*gridX,
//			                     Mathf.Round(newPos.y/gridY)*gridY);
			transform.Translate (Vector3.right * speed * Time.deltaTime);
			direction = "right";
		} else {
			direction = "neutral";
		}
	}
}
