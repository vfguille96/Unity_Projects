using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Trasladar : MonoBehaviour
{
	public TextMeshPro _magnitud;

	public Transform _origen;
	public Transform _destino;

	private float _vel;

	private Vector3 _distancia;
	private Vector3 _direccion;

	private bool _enMovimiento;
	// Use this for initialization
	void Start ()
	{
		_vel = 0.01F;
	}
	
	// Update is called once per frame
	void Update ()
	{
		DetectarMovimiento();
		Trasladando();
	}

	private void DetectarMovimiento()
	{
		if (Input.GetKeyDown(KeyCode.Space))
			_enMovimiento = true;
	}

	void Trasladando()
	{
		_distancia = _destino.position - _origen.position;
		if (_enMovimiento)
		{
			_direccion = _destino.position - _origen.position;
			_origen.Translate(_direccion * _vel);
		}

		_magnitud.text = _distancia.magnitude.ToString();
		if (_distancia.magnitude < 0.2F)
			_enMovimiento = false;
	}
}
