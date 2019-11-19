using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Acciones : MonoBehaviour
{
	private float _tiempoTotal;
	private Rigidbody rbG0;
	private bool _sleep;

	// Use this for initialization
	void Start ()
	{
		rbG0 = gameObject.AddComponent<Rigidbody>();
		rbG0.mass = 10;
		Physics.gravity = new Vector3(0, -20, 0);
		_sleep = false;
		_tiempoTotal = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (_tiempoTotal > 1)
		{
			if (_sleep)
			{
				rbG0.WakeUp();
				Debug.Log("Despierto ==> WakeUp()");
			}else
			{
				rbG0.Sleep();
				Debug.Log("Dormido ==> Sleep()");
			}
			_sleep = !_sleep;
			_tiempoTotal = 0;
		}

		_tiempoTotal += Time.deltaTime;
	}
}
