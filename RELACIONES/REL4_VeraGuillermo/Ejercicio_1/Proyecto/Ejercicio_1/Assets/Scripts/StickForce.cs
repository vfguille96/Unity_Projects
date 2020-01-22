﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickForce : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.GetComponent<MeshFilter>().sharedMesh.name.Equals("Cylinder"))
		{
			gameObject.GetComponent<Rigidbody>().AddTorque(Vector3.left, ForceMode.Impulse);
		}
	}
}
