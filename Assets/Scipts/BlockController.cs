using UnityEngine;
using System.Collections;

public class BlockController : MonoBehaviour {

	public double health = 5;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (health <= 0) {
			Destroy (gameObject);
		}
	}

	void applyDamage(double damage) {
		health -= damage;
	}
	
}
