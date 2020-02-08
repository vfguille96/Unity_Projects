using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverJugador : MonoBehaviour
{
	private Rigidbody _rigidbody;
	public float _vel;
	public float _salto;
	private static bool _suelo;
	public GameObject _camara;
	private float _rotY_camara;

	// Use this for initialization
	void Start ()
	{
		_suelo = true;
	}
	
	// Update is called once per frame
	void Update ()
	{
		_rotY_camara = _camara.transform.eulerAngles.y;
		transform.eulerAngles = new Vector3(transform.rotation.x, transform.rotation.y, 0);
		_rigidbody.MovePosition(transform.position + (_camara.transform.forward * (Input.GetAxis("Vertical") * _vel)) + 
		                        (_camara.transform.right * (Input.GetAxis("Horizontal") * _vel)));
		if (Input.GetKeyDown(KeyCode.Space) && _suelo)
			_rigidbody.AddForce(transform.up * _salto);
	}

	private void FixedUpdate()
	{
		_rigidbody = GetComponent<Rigidbody>();
	}

	private void OnCollisionStay(Collision other)
	{
		Debug.Log(other.gameObject.name);
		if (other.gameObject.name.Equals("dust2_map"))
		{
			_suelo = true;
		}
		else
			_suelo = false;
	}

	private void OnCollisionExit(Collision other)
	{
		if (other.gameObject.name.Equals("dust2_map"))
		{
			_suelo = false;
		}
		else
			_suelo = true;
	}
}
