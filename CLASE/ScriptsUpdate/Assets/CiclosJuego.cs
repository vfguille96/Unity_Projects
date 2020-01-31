using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CiclosJuego : MonoBehaviour {
	private void Awake()
	{
		Debug.Log("Awake");
	}

	// Use this for initialization
	void Start () {
		Debug.Log("Start");
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log("Update");
	}

	private void FixedUpdate()
	{
		Debug.Log("FixedUpdate");
	}

	private void OnGUI()
	{
		Debug.Log("OnGUI");
	}

	private void LateUpdate()
	{
		Debug.Log("LateUpdate");
	}
}
