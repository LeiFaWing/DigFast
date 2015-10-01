using UnityEngine;
using System.Collections;

public class DigController : MonoBehaviour {

	GameObject player;
	PlayerController pc;
	public string trigger;
	
	// Use this for initialization
	void Start () {
		player = GameObject.Find ("Player");
		pc = player.GetComponent<PlayerController> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnTriggerStay2D(Collider2D col) {
		if (col.gameObject.tag == "Block") {
			if (pc.direction == trigger) {
				col.gameObject.SendMessage("applyDamage", Manager.damage*Time.deltaTime);
			}
		}
	}
}
