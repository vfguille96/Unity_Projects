using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{

	public Button _btCinematcs;
	public Button _btPhysics;
	
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		_btCinematcs.onClick.AddListener(ChangeSceneCinematics);
		_btPhysics.onClick.AddListener(ChangeScenePhysics);
		ExitGame();
	}

	private void ChangeScenePhysics()
	{
		SceneManager.LoadScene("Scenes/Physics");
	}

	private void ChangeSceneCinematics()
	{
		SceneManager.LoadScene("Scenes/Cinematic");
	}

	private static void ExitGame()
	{
		if (Input.GetKeyUp(KeyCode.Escape))
			Application.Quit();
	}
}
