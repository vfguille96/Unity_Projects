using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {
	private const float _MIN = -5;
	private const float _MAX = 5;
	private float _posX;
	private float _posZ;
	private float _vel = 7;

	// Use this for initialization
	void Start ()
	{
		_posX = 0;
		_posZ = 0;
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (GasControl._Gas)
		{
			_posX += Input.GetAxis("Horizontal") * _vel * Time.deltaTime;
			_posZ += Input.GetAxis("Vertical") * _vel * Time.deltaTime;
			_posX = Mathf.Clamp(_posX, _MIN, _MAX);
			_posZ = Mathf.Clamp(_posZ, _MIN, _MAX);
			transform.position = new Vector3(_posX, transform.position.y, _posZ);
		}
	}
}
