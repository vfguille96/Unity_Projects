using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hijos : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void Accion(string texto)
	{
		Debug.Log("Soy el hijo: " + gameObject.name);
	}
}
