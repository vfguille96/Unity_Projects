using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bola : MonoBehaviour
{
	public float _fuerzaTorque = 300;
	private Vector3 _aplicarFuerza;
	public float _fuerzaImpulso = 300;
	private Rigidbody _rigidbody;

	void Start ()
	{
		_rigidbody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		_aplicarFuerza = - Time.deltaTime * _fuerzaTorque * Input.GetAxis("Horizontal") * Vector3.up;
		_rigidbody.AddTorque(_aplicarFuerza, ForceMode.Force);
		if (Input.GetButtonDown("Vertical"))
		{
			 GetComponent<Rigidbody>().AddForce(Time.deltaTime * _fuerzaImpulso * Vector3.forward);
		}
	}
}
