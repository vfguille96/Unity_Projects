using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBall : MonoBehaviour
{

	public float _vel = 150;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void FixedUpdate()
	{
		if (Input.GetKeyDown(KeyCode.UpArrow))
		{
			GetComponent<Rigidbody>().AddForce(Vector3.forward * _vel, ForceMode.Acceleration);
		}
		
		if (Input.GetKeyDown(KeyCode.DownArrow))
		{
			GetComponent<Rigidbody>().AddForce(Vector3.back * _vel, ForceMode.Acceleration);
		}
		
		if (Input.GetKeyDown(KeyCode.RightArrow))
		{
			GetComponent<Rigidbody>().AddForce(Vector3.right * _vel, ForceMode.Acceleration);
		}
		
		if (Input.GetKeyDown(KeyCode.LeftArrow))
		{
			GetComponent<Rigidbody>().AddForce(Vector3.left * _vel, ForceMode.Acceleration);
		}
	}

	private void OnCollisionEnter(Collision other)
	{
		if (!other.gameObject.name.Equals("Plane"))
		{
			other.gameObject.GetComponent<Renderer>().material.color = Color.green;
		}
	}
}
