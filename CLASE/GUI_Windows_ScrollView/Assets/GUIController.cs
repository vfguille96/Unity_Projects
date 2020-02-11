using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUIController : MonoBehaviour {
	
	Vector2 posScroll = new Vector2(10, 10);
	private string contenido = "Contenido del Scroll adashfskjhf";
	Rect area1 = new Rect(25, 25, 120, 120);
	Rect area2 = new Rect(0, 0, 320, 320);	// Área respecto a su contenedor, no absoluto.
	private bool mostrar = false;

	private void Update()
	{
		if (Input.GetKeyUp(KeyCode.Space))
			mostrar = !mostrar;
	}

	private void OnGUI()
	{
		/*
		// GUI.BeginScrollView
		posScroll = GUI.BeginScrollView(area1, posScroll, area2);
		contenido = GUI.TextArea(new Rect(0, 0, 320, 320), contenido);
		GUI.Button(new Rect(10, 20, 100, 30), "Hola caracola");
		GUI.EndScrollView();
		// GUI.EndScrollView
		
		*/

		if (mostrar)
			MostrarVentana("Hola Caracola");
	}

	float ancho = 400;
	float alto = 200;
	float x;
	float y;
	void MostrarVentana(string contenido)
	{
		x = (Screen.width / 2) - (ancho / 2);
		y = (Screen.height / 2) - (alto / 2);
		
		Rect area = new Rect(x, y, ancho, alto);
		area = GUI.Window(0, area, FuncionVentana, contenido);
	}

	private float ancho_w = 140;
	private float alto_w = 40;
	public float x_w;
	public float y_w;
	void FuncionVentana(int id)
	{
		x_w = (area1.width / 2) - (ancho_w / 2);
		y_w = (area1.height / 2) - (alto_w / 2);
		Rect areaBoton = new Rect(x_w, y_w, ancho_w, alto_w);
		if (GUI.Button(areaBoton, "Pulse"))
		{
			Debug.Log("CLICK en la ventana ID: " + id);
		}
	}
}
