using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickImpulse : MonoBehaviour {
	public float _impulseForce = 80;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void FixedUpdate()
	{
		if (Input.GetMouseButtonUp(0))
		{
			GetComponent<Rigidbody>().AddTorque(Vector3.forward * _impulseForce, ForceMode.Impulse);
		}
	}
}
