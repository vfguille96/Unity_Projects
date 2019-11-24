using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using TMPro;
using UnityEngine.UI;

public class Texto : MonoBehaviour
{
	public Slider _sliderR;
	public Slider _sliderG;
	public Slider _sliderB;
	
	public TextMeshProUGUI _textMeshProUgui;
	
	public string texto;
	public float _vel;
	
	private float _r;
	private float _g;
	private float _b;
	
	// Use this for initialization
	void Start ()
	{
		InicializarComponentes();
	}
	
	// Update is called once per frame
	void Update ()
	{
		ValoresColoresSlider();

		EstablecerTexto();
		EstablecerColor();
		
		MovimientoTexto();
	}

	private void InicializarComponentes()
	{
		InicializarVelocidadTexto();
		InicializarSliders();
		InicializarColores();
	}

	private void InicializarVelocidadTexto()
	{
		texto = "Hola Caracola";
		_vel = 18;
	}

	private void InicializarSliders()
	{
		_sliderB.value = 1;
		_sliderR.value = 1;
		_sliderG.value = 1;
	}

	private void InicializarColores()
	{
		_r = 1;
		_g = 1;
		_b = 1;
	}

	private void MovimientoTexto()
	{
		Vector3 pos = transform.position;
		Vector3 localVectorUp = transform.TransformDirection(Vector3.up);
		pos += localVectorUp * _vel * Time.deltaTime;
		transform.position = pos;
	}

	private void EstablecerColor()
	{
		_textMeshProUgui.color = new Color(_r, _g, _b);
	}

	private void EstablecerTexto()
	{
		_textMeshProUgui.text = texto;
	}

	private void ValoresColoresSlider()
	{
		_r = _sliderR.value;
		_g = _sliderG.value;
		_b = _sliderB.value;
	}

	private void OnGUI()
	{
		Rect pos2;
		var pos = InicializarBotonesGUI(out pos2);
		VerificarOnOff(pos);
		Invertir(pos2);
	}

	private void Invertir(Rect pos2)
	{
		if (GUI.Button(pos2, "Invertir"))
		{
			if (_vel != -18)
				_vel = -18;
			else
				_vel = 18;
		}
	}

	private void VerificarOnOff(Rect pos)
	{
		if (GUI.Button(pos, "On/Off"))
		{
			if (_vel != 0)
				_vel = 0;
			else
				_vel = 18;
		}
	}

	private static Rect InicializarBotonesGUI(out Rect pos2)
	{
		Rect pos = new Rect(20, 10, 250, 50);
		pos2 = new Rect(20, 60, 250, 50);
		return pos;
	}
}