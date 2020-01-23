using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickForce : MonoBehaviour
{
	public GameObject _stick;
	private Vector3 _pushForce;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		_pushForce = _stick.gameObject.transform.position;
	}

	private void OnCollisionEnter(Collision other)
	{
		
		if (other.gameObject.GetComponent<MeshFilter>().sharedMesh.name.Equals("Cylinder"))
		{
			gameObject.GetComponent<Rigidbody>().AddTorque(_pushForce, ForceMode.Impulse);
		}
	}
}
