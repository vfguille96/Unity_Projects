using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitScene : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		ExitSceneEsc();
	}
	
	private static void ExitSceneEsc()
	{
		if (Input.GetKeyDown(KeyCode.Escape))
			SceneManager.LoadScene("Scenes/Menu");
	}
}
