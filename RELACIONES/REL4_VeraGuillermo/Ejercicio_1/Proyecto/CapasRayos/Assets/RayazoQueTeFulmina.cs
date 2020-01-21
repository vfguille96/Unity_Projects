using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Asignado al obj. emisor del rayo que te deja tieso.
public class RayazoQueTeFulmina : MonoBehaviour
{
	// Version 1
	private Vector3 _oRay;
	private Vector3 _dirRay;
	private float _longRay;
	private RaycastHit _raycastHit;
	
	// version 2: layers
	private int _masJug = 512;	// 200 EXA
	private int _masBasura = 0x4000; // 2^14	4000 EXA
	private int _masJugBas = 0x4200;	// 4200 EXA
	
	void Start ()
	{
		_dirRay = Vector3.back;
		_longRay = Mathf.Infinity;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		DetectarTodosLosObjetos();
		DetectarTodosLosObjetosAlgunasCapas(_masBasura);
	}

	void DetectarTodosLosObjetos()
	{
		_oRay = transform.position;
		if (Physics.Raycast(_oRay, _dirRay, out _raycastHit, _longRay))
			Debug.Log("Objeto detectado: " + _raycastHit.collider.name.ToUpper());
	}
	
	void DetectarTodosLosObjetosAlgunasCapas(int layer)
	{
		_oRay = transform.position;
		if (Physics.Raycast(_oRay, _dirRay, out _raycastHit, _longRay, layer))
			Debug.Log("Objeto detectado CAPA: " + _raycastHit.collider.name.ToUpper());
	}
	
	
}
