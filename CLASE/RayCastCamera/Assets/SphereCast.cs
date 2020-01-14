using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereCast : MonoBehaviour
{
	private Vector3 _posI;
	private float _radSphere;
	private RaycastHit _infoRay;
	private Vector3 _dirRay;
	private float _longRay;

	// Use this for initialization
	void Start ()
	{
		_radSphere = transform.localScale.x / 2;
		_dirRay = Vector3.forward;
		_longRay = 100;
	}
	
	// Update is called once per frame
	void Update ()
	{
		_posI = transform.position;
		if (Physics.SphereCast(_posI, _radSphere, _dirRay, out _infoRay, _longRay))
		{
			Debug.LogFormat("Detectado un obstáculo: {0} a {1} metros.", _infoRay.collider.name, _infoRay.distance);
			_infoRay.collider.gameObject.GetComponent<Renderer>().material.color = Color.green;
		}

	}
}
