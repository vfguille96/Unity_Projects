using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class abrirCerrar : MonoBehaviour {
	public float _velRot = 3;
	private bool isOpen = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKeyDown(KeyCode.A))
			isOpen = true;
		if (Input.GetKeyDown(KeyCode.S))
			isOpen = false;
		OpenOrClose();
	}

	private void OpenOrClose()
	{
		(isOpen ? (Action) Abrir : Cerrar)();
	}

	private void Abrir()
     	{
     		transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, 90, 0), _velRot * Time.deltaTime);
        }
	
	private void Cerrar()
	{
		transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, 0, 0), _velRot * Time.deltaTime);
		isOpen = false;
	}
}
