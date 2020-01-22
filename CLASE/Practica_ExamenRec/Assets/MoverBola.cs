using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverBola : MonoBehaviour {

	private const float VEL = 20;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += new Vector3(Input.GetAxis("Horizontal") * Time.deltaTime * VEL, 0, Input.GetAxis("Vertical") * Time.deltaTime * VEL);
	}
}
