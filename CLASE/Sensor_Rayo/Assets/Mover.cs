using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
	private Rigidbody _rigidbody;
	private float _fuerzaEmpuje = 10;

	// Use this for initialization
	void Start ()
	{
		_rigidbody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		float h = Input.GetAxis("Horizontal");
		float v = Input.GetAxis("Vertical");
		_rigidbody.AddForce(new Vector3(h * _fuerzaEmpuje, 0 , v * _fuerzaEmpuje));
	}
}
