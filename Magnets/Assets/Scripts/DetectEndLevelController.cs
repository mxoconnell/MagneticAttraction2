using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectEndLevelController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnTriggerEnter(Collider collider){
		if(collider.transform.tag.Equals("Player")){
			GameManager.LoadNextScene();
		}
	}
}
