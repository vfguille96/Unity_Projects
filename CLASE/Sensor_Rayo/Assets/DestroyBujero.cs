using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBujero : MonoBehaviour {
	private void OnTriggerEnter(Collider other)
	{
		Destroy(other.gameObject, 0);
	}
}
