using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnCollisionEnter(Collision other)
	{
		Debug.LogFormat("ENTER: Colisionando con {0}", other.collider.name);
	}

	private void OnCollisionExit(Collision other)
	{
		Debug.LogFormat("EXIT: Colisionando con {0}", other.collider.name);

	}

	private void OnCollisionStay(Collision other)
	{
		Debug.LogFormat("STAY: Colisionando con {0}", other.collider.name);
	}
}
