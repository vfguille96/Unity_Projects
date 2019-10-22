using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class contador : MonoBehaviour {
public Text _contador;
private double _myTime = 0;
private float _vel = 10;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		_myTime += Time.deltaTime * Math.Exp((double)_vel);
		_contador.text = _myTime.ToString("0000");

	}

	public void poner0()
	{
		_contador.text = "0";
	}
}
