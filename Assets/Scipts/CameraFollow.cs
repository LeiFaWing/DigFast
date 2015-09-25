using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

	public GameObject player;
	Vector3 offset;

	// Use this for initialization
	void Start () {
		offset = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void LateUpdate() {

		// if player is alive
		if (player != null) {
		
			//remove jitter by following the player closely, instead of exactly

			//follow distance in unity units
			float followDistance = 0.1f;

			//this is where the camera would go if it were tracking the player exactly
			Vector3 playerPos = player.transform.position + offset;

			Vector3 newPos = transform.position; //start at current camera position
		
			//if player is off-center to left
			if (playerPos.x < newPos.x - followDistance) {
				newPos.x = playerPos.x + followDistance;
			}
			//if player is off-center to right
			if (playerPos.x > newPos.x + followDistance) {
				newPos.x = playerPos.x - followDistance;
			}
			//if player is off-center downward
			if (playerPos.y < newPos.y - followDistance) {
				newPos.y = playerPos.y + followDistance;
			}
			//if player is off-center upward
			if (playerPos.y > newPos.y + followDistance) {
				newPos.y = playerPos.y - followDistance;
			}

			transform.position = newPos;

		}

	}
}
