using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class CambiarColorColision : MonoBehaviour
{

	private bool _clic;
	// Use this for initialization
	void Start ()
	{
		_clic = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonUp(0))
		{
			if (_clic)
				_clic = false;
			else
				_clic = true;
		}
		
		if (_clic)
			transform.gameObject.GetComponent<Renderer>().material.color = Color.blue;
		Debug.Log(_clic);
	}

	private void OnTriggerStay(Collider other)
	{
		if (!_clic && other.gameObject.tag.Equals("Zona"))
			transform.gameObject.GetComponent<Renderer>().material.color = Color.red;
		Debug.Log("ENTEEER");
	}

	private void OnTriggerExit(Collider other)
	{
		if (other.gameObject.tag.Equals("Zona"))
			transform.gameObject.GetComponent<Renderer>().material.color = Color.blue;
		Debug.Log("SALEEEEEEEEEE");
	}
}
