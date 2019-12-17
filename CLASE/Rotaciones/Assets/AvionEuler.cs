using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvionEuler : MonoBehaviour
{
	public float _velRot = 90;

	// Los miembros se heredan.
	protected float _rotEjeX;
	protected float _rotEjeY;
	protected float _rotEjeZ;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		// Asignar los valores en función de la tecla pulsada.
		_rotEjeZ = Input.GetAxis("Vertical");
		_rotEjeY = Input.GetAxis("Horizontal");
		// Se usan las teclas Z y X
		_rotEjeX = Input.GetAxis("EjeX");
		
		AplicarRotacion();
	}

	protected virtual void AplicarRotacion()
	{
		Vector3 rotacionActual = transform.localEulerAngles;
		
		// Modificamos la rotación actual con los valores leídos.
		rotacionActual.x += _rotEjeX * _velRot * Time.deltaTime;
		rotacionActual.y += _rotEjeY * _velRot * Time.deltaTime;
		rotacionActual.z += _rotEjeZ * _velRot * Time.deltaTime;

		transform.eulerAngles = rotacionActual;
	}

	private void OnGUI()
	{
		GUI.color = Color.black;
		GUILayout.Label("Rotacion X: " + _rotEjeX);
		GUILayout.Label("Rotacion Y: " + _rotEjeY);
		GUILayout.Label("Rotacion Z: " + _rotEjeZ);
	}
}
