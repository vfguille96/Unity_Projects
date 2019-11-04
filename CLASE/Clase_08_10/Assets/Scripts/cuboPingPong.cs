using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class cuboPingPong : MonoBehaviour {
	private float _max = 5;
	private float _vel = 5;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		//transform.position = new Vector3(transform.position.x, transform.position.y, Mathf.PingPong(Time.time * _vel, _max));
		var position = transform.position;
		position = new Vector3(position.x, position.y, Mathf.PingPong(Time.time * _vel, _max + _max) -_max);
		transform.position = position;
	}
}
