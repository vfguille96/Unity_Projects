using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Object = System.Object;

public class changeScene : MonoBehaviour
{
	public GameObject scene;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Escape))
			Exit();
	}
	
	public void changeScene2(){
	    SceneManager.LoadScene("Essena2");
	}
	public void changeScene1(){
		SceneManager.LoadScene("Essena1");
	}

	public void Exit()
	{
		Application.Quit();
	}
	
}
