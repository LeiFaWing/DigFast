using UnityEngine;
using System.Collections;

public class BlockController : MonoBehaviour {

	public double health = 5;
	public GameObject powerup;
	public bool isGold = false;
	public bool isSilt = false;
	public bool isGoldSupply = false;
	public bool isMetal = false;
	double initialHealth;


	// Use this for initialization
	void Start () {
		initialHealth = health;
	}
	
	// Update is called once per frame
	void Update () {
		if (health <= 0) {
			// drop powerup
			if (initialHealth * Random.Range(1, 10) >= 60) {
				Instantiate(powerup, transform.position, Quaternion.identity);
			}

			if (isGold) {
				Manager.score += 15;
			}
			else if (isGoldSupply) {
				Manager.score += 30;
			}

			Manager.score += (int) initialHealth;
			Destroy (gameObject);
		}
	}

	void applyDamage(double damage) {
		health -= damage;
	}
	
}
