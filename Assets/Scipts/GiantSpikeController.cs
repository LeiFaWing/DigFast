using UnityEngine;
using System.Collections;

public class GiantSpikeController : MonoBehaviour {

	public float speed;
	float previousy;
	float currenty;
	public float maxSpeed;

	// Use this for initialization
	void Start () {
		previousy = transform.position.y;
		currenty = previousy;
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector3.down * speed * Time.deltaTime);

		currenty = transform.position.y;

		// increase speed of spike
		if (Mathf.Abs (previousy - currenty) > 5) {
			speed = (float) (speed + 0.1);
			previousy = currenty;
		}

		// limit how fast spike moves down screen
		if (speed > maxSpeed) {
			speed = maxSpeed;
		}
	}

	void OnTriggerEnter2D(Collider2D col) {
		if (col.gameObject.tag == "Player") {
			col.gameObject.SendMessage("gameOver");
			Destroy(col.gameObject);
		}
	}
}
