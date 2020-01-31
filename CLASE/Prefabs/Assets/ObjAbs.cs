using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjAbs : MonoBehaviour
{

	public float _velRot;
	Vector3 _rot;

	// Use this for initialization
	void Start ()
	{
		_velRot = 10;
		_rot = Vector3.one *_velRot;
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(_rot);
	}
}
