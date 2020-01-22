using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Holes : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnCollisionStay(Collision other)
	{
		if (other.gameObject.GetComponent<MeshFilter>().sharedMesh.name.Equals("Sphere"))
		{
			Destroy(other.gameObject, 0);
		}
	}
}
