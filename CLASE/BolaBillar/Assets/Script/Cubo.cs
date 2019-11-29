using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class Cubo : MonoBehaviour
{
	[FormerlySerializedAs("_Vector3")] public Vector3 _posInicial;
	private Quaternion q1;

	private Rigidbody _rigidbody;

	// Use this for initialization
	void Start ()
	{
		_rigidbody = GetComponent<Rigidbody>();
		_posInicial = Vector3.zero;
	}
	
	// Update is called once per frame
	void Update()
	{
		_rigidbody.position = _posInicial;
	}
}
