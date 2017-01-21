using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	private static GameManager _instance;

	public static GameManager Instance{
		get{
			if(_instance == null){
				_instance = new GameManager ();
			}

			return _instance;
		}
	}

	void Awake(){
		DontDestroyOnLoad (this.gameObject);		
	}

	public static void LoadNextScene(){
		Scene currentScene = SceneManager.GetActiveScene(); //scenes work based off array;
		int currentSceneCount = currentScene.buildIndex;
		SceneManager.LoadScene(currentSceneCount++);
	}
}
