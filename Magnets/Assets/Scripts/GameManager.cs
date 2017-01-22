using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	public void LoadSceneByName(string name){
		SceneManager.LoadScene (name);
	}

	public void LoadNextScene(){
		Scene currentScene = SceneManager.GetActiveScene(); //scenes work based off array;
		int currentSceneCount = currentScene.buildIndex;
		SceneManager.LoadScene(currentSceneCount++);
	}
}
