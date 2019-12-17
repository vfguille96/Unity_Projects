using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotor : MonoBehaviour {

	public float _velRot = 100;
	public float _x = 0;
	public float _y = 0;
	public float _z = 0;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//transform.Rotate(Vector3.up * _velRot * Time.deltaTime);
		transform.Rotate(new Vector3(_x * _velRot * Time.deltaTime, _y * _velRot * Time.deltaTime, _z * _velRot * Time.deltaTime));
	}
}
