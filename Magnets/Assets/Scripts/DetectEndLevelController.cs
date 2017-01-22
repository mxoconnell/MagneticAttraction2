using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectEndLevelController : MonoBehaviour {

	private GameManager gameManager;

	// Use this for initialization
	void Start () {
		gameManager = FindObjectOfType<GameManager> ();	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnTriggerEnter(Collider collider){
		if(collider.transform.tag.Equals("Player")){
			gameManager.LoadNextScene();
		}
	}
}
