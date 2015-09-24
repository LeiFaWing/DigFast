using UnityEngine;
using System.Collections;

public class GiantSpikeController : MonoBehaviour {

	public int speed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector3.down * speed * Time.deltaTime);
	}

	void OnTriggerEnter2D(Collider2D col) {
		if (col.gameObject.tag == "Player") {
			Destroy(col.gameObject);
		}
	}
}
