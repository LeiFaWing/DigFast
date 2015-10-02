using UnityEngine;
using System.Collections;

public class TitleController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void startGame(){
		Manager.win = false;
		Manager.score = 0;
		Application.LoadLevel ("main");
	}

}
