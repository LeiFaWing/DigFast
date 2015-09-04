﻿using UnityEngine;
using System.Collections;

public class BottomTrigger : MonoBehaviour {

	GameObject player;
	PlayerController pc;
	
	
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
			if (pc.down) {
				Destroy (col.gameObject);
			}
		}
	}
}