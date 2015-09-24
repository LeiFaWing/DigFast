using UnityEngine;
using System.Collections;

public class Manager : MonoBehaviour {

	// add more blocks if necessary
	// probably find a more efficient way to do this
	public GameObject block1;
	public GameObject block2;

	public float spacing;
	GameObject player;
	//PlayerController pc;
	int previousy;

	// Use this for initialization
	void Start () {

		GameObject[] blocks = {block1, block2};

		// create blocks
		for (int i = -4; i < 5; i++) {
			for (int j = 0; j > -100; j--) {
				// space out blocks properly
				Vector3 pos = new Vector3(i, j, 0) * spacing;
				// randomize block choice
				int num = (int) Random.Range(0, blocks.Length);
				Instantiate(blocks[num], pos, Quaternion.identity);
			}
		}

		//player = GameObject.Find ("Player");
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
	}

	void LateUpdate() {

	}
}
