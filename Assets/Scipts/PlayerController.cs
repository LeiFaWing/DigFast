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
	public GameObject loseScreen;

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

			//fix player to grid, so you can't dig between blocks
			//raycast to see which block is underneath the player
			Vector3 raycastStartPos=transform.position;
			raycastStartPos.y -= 0.4f; //lower the starting point into the buttomCollision digger detector
			//raycast downword and hit the nearest block.
			RaycastHit2D hitInfo = Physics2D.Raycast(raycastStartPos, Vector3.down, 1.4f);
			//get the x-pos of the block
			if(hitInfo.collider != null){
			float newX=hitInfo.collider.transform.position.x;
				Debug.Log("newX:"+newX);
				Vector3 playerPos=transform.position;
				playerPos.x=newX;
				transform.position=playerPos;
			}


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

	void gameOver() {
		Vector3 pos = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, -2);
		Instantiate(loseScreen, pos, Quaternion.identity);
	}
}
