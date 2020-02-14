using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Receptor : MonoBehaviour
{

	private bool mostrarTexto;
	private string texto;

	private void Start()
	{
		mostrarTexto = false;
	}

	void Accion(string texto)
	{
		mostrarTexto = true;
		this.texto = texto;
		AplicarCambios();
	}
	
	private void OnGUI()
	{
		GUI.color = Color.red;
		GUIStyle estilo = new GUIStyle();
		estilo.fontSize = 40;

		if (mostrarTexto)
			GUILayout.Label(texto, estilo);
	}

	private void AplicarCambios()
	{
		gameObject.GetComponent<Renderer>().material.color = Color.blue;
		gameObject.AddComponent<Rigidbody>();
	}
}
