using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Emisor : MonoBehaviour
{
	private Vector3 fwd;	// Dirección Rayo
	private int _alcance = 100;
	private RaycastHit[] _objetosDetectados;

	// Use this for initialization
	void Start ()
	{
		fwd = transform.TransformDirection(Vector3.right * _alcance);
	}
	
	// Update is called once per frame
	void Update ()
	{
		_objetosDetectados = Physics.RaycastAll(transform.position, fwd);

		foreach (var VARIABLE in _objetosDetectados)
		{
			Debug.Log("DETECTADO TIPO" + VARIABLE.GetType() + " - " + " DISTANCIA:" + VARIABLE.distance + " - "
			          + " COLLIDER: " + VARIABLE.collider.gameObject.name);
		}

		if (Physics.Raycast(transform.position, fwd))
		{
			Debug.Log("AYYY PIRATILLA!!!");
		}
		
		Debug.DrawRay(transform.position, fwd, Color.red);

		if (Input.GetKey(KeyCode.Space))
		{
			transform.Rotate(new Vector3(0, 1, 0));
			fwd = transform.TransformDirection(Vector3.right * _alcance++);
		}
	}
}
