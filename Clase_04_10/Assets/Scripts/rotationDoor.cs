using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotationDoor : MonoBehaviour {

	// Use this for initialization
	private Quaternion _origen;
	private Quaternion _destino;
	public float _vel = 0F;
	void Start () {
		_origen = transform.rotation;
		_destino = Quaternion.Euler(0, 180, 0);
		_vel *= Time.time;
	}
	
	// Update is called once per frame
	void Update () {
		// Puerta
		transform.rotation = Quaternion.Lerp(_origen, _destino, _vel);
	}
}
