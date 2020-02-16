using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MensajeGUILabel : MonoBehaviour
{
	private float x_window;
	private float y_window;
	private bool visualizarVentana;
	float ancho = 400;
	float alto = 200;
	float x;
	float y;
	private float ancho_w = 140;
	private float alto_w = 40;
	public float x_w;
	public float y_w;
	Rect area1 = new Rect(25, 25, 120, 120);
	
	void MostrarVentana(int id)
	{
		x_w = (area1.width / 2) - (ancho_w / 2);
		y_w = (area1.height / 2) - (alto_w / 2);
	}

	void MostrarMensajePantalla(string mensaje)
	{
		x = (Screen.width / 2) - (ancho / 2);
		y = (Screen.height / 2) - (alto / 2);
		
		Rect area = new Rect(x, y, ancho, alto);
		area = GUI.Window(0, area, MostrarVentana, mensaje);
	}

	private void Update()
	{
		MostrarV();
	}

	private void MostrarV()
	{
		if (Input.GetKeyUp(KeyCode.Space))
			visualizarVentana = !visualizarVentana;
	}

	// Use this for initialization
	void Start ()
	{
		visualizarVentana = false;
	}

	private void OnGUI()
	{
		if (visualizarVentana)
			MostrarMensajePantalla("Soy el mensaje mostrado con GUI.Label");
	}
}