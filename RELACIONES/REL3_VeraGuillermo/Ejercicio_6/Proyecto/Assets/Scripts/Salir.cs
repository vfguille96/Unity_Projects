﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Salir : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		ExitGame();
	}

	private static void ExitGame()
	{
		if (Input.GetKeyUp(KeyCode.Escape))
			Application.Quit();
	}
}
