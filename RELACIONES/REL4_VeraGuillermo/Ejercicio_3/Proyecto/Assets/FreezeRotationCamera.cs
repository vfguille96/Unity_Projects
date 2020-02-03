using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreezeRotationCamera : MonoBehaviour {
	public Transform target;

	// Use this for initialization

	void Start () {
		
	}

	void Update()
	{
		Vector3 relativePos = target.position - transform.position;
		Quaternion rotation = Quaternion.LookRotation(relativePos, Vector3.up);
		transform.rotation = rotation;
	}
}
