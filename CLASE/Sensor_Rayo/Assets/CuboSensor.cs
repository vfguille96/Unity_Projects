using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Asignado al sensor
public class CuboSensor : MonoBehaviour {
	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.name == "Sphere")
		{
			other.gameObject.transform.position = new Vector3(0, 3.5F, 0);
			other.GetComponent<Renderer>().material.color = Color.red;
		}
		Debug.Log("CAUGHT");
	}
}
