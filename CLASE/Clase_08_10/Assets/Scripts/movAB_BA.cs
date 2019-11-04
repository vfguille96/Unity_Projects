using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
 * Asignado a la cápsula para movel del punto A al B y viceversa.
 */
public class movAB_BA : MonoBehaviour
{
	private float _min = -5;
	private float _max = 5;
	
	// Valor inicial del tiempo
	public float t = 0.0F;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		var position = transform.position;
		position = new Vector3(Mathf.Lerp(_min, _max, t), position.y, position.z);
		transform.position = position;
		t += 0.8F * Time.deltaTime;
		//t = Time.time;

		float TOLERANCE = 1F;
		if (t >= TOLERANCE)
		{
			float temp = _max;
			_max = _min;
			_min = temp;
			t = 0;
		}
	}
}
