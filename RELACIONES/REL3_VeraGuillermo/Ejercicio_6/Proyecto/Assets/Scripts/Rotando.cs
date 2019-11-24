using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotando : MonoBehaviour
{
	private Vector3 _velRot;
	// Use this for initialization
	void Start () {
		_velRot = new Vector3(0.53F, 0.53F, 0.53F);
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(_velRot);
	}
}
