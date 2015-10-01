using UnityEngine;
using System.Collections;

public class Manager : MonoBehaviour {

	public static int damage = 35;
	public static int score = 0;
	public static bool powerup = false;
	public static bool win = false;

	int previousScore;
	public static int powerupTime = 100;
	int initialDamage;

	// add more blocks if necessary
	// probably find a more efficient way to do this
	public GameObject block1;
	public GameObject block2;
	public GameObject block3;
	public GameObject block4;
	public GameObject block5;
	public GameObject block6;
	public GameObject block7;
	public GameObject block8;
	public GameObject block9;

	public GUIText scoreText;
	public GUIText powerupText;

	public float spacing;
	GameObject player;
	//PlayerController pc;
	int previousy;

	// Use this for initialization
	void Start () {

		previousScore = score;
		initialDamage = damage;
		GameObject[] blocks = {block1, block2, block3, block4, block5, block6, block7, block8, block9};

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

					// if gold block
					if (bc.isGold) {
						// increase end range to make lower chances of gold spawning
						if (bc.health * Random.Range(1, 350) < 15) {
							created = true;
						}
					}
					// if silt block
					else if (bc.isSilt) {
						if (bc.health * Random.Range(1, 350) < 15) {
							created = true;
						}
					}
					// metal blocks
					else if (bc.isMetal) {
						if (Random.Range(1, 700) < 5) {
							created = true;
						}
					}
					// all other blocks
					else {
						if (bc.health * Random.Range(1, 50) <= 15) {
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

		// if player is dead
		if (player == null || win) {
			// reset game when space is pressed
			if (Input.GetKey(KeyCode.Space)) {
				Application.LoadLevel ("title");
			}
		}

		if (score != previousScore) {
			UpdateScore();
		}

		if (powerup) {
			damage = 2 * initialDamage;
			powerupText.enabled = true;
			powerupText.text = "Powerup: " + powerupTime;
			powerupTime--;
		}

		if (powerupTime <= 0) {
			powerup = false;
			powerupTime = 100;
			damage = initialDamage;
			powerupText.enabled = false;
		}
	}

	void UpdateScore() {
		scoreText.text = "Score: " + score;
		previousScore = score;
	}

	void LateUpdate() {

	}
}
