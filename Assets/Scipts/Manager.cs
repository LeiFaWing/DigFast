﻿using UnityEngine;
using System.Collections;

public class Manager : MonoBehaviour {

	public static int damage = 35;

	// add more blocks if necessary
	// probably find a more efficient way to do this
	public GameObject block1;
	public GameObject block2;
	public GameObject block3;
	public GameObject block4;
	public GameObject block5;
	public GameObject block6;
	public GameObject block7;

	public float spacing;
	GameObject player;
	//PlayerController pc;
	int previousy;

	// Use this for initialization
	void Start () {

		GameObject[] blocks = {block1, block2, block3, block4, block5, block6, block7};

		// create blocks
		for (int i = -4; i < 5; i++) {
			for (int j = 0; j > -100; j--) {
				// space out blocks properly
				Vector3 pos = new Vector3(i, j, 0) * spacing;

				bool created = false;
				int num = (int) Random.Range(0, blocks.Length);

				while (!created) {
					// randomize block choice
					num = (int) Random.Range(0, blocks.Length);

					BlockController bc = blocks[num].GetComponent<BlockController>();

					// if not gold block
					if (!bc.isGold) {
						if (bc.health * Random.Range(1, 5) <= 15) {
							created = true;
						}
					}
					else {
						if (bc.health * Random.Range(1, 10) <= 10) {
							created = true;
						}
					}
				}

				Instantiate(blocks[num], pos, Quaternion.identity);
			}
		}

		player = GameObject.Find ("Player");
		//pc = player.GetComponent<PlayerController> ();
		//previousy = (int) player.transform.position.y;
	}
	
	// Update is called once per frame
	void Update () {
//		int currenty = (int) player.transform.position.y;
//		if (currenty < previousy) {
//			for (int i = -4; i < 5; i++) {
//				for (int j = currenty - 2; j > currenty - 12; j--) {
//					Vector3 pos = new Vector3(i, j, 0) * spacing;
//					Instantiate(block, pos, Quaternion.identity);
//					Debug.Log(j);
//				}
//			}
//			previousy = currenty;
//		}

		// if player is dead
		if (player == null) {
			// reset game when space is pressed
			if (Input.GetKey(KeyCode.Space)) {
				Application.LoadLevel ("title");
			}
		}
	}

	void LateUpdate() {

	}
}
