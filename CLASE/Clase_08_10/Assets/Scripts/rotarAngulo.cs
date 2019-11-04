using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotarAngulo : MonoBehaviour
{
	public float _angI = 0;
	public float _angF = 180;
	private float _ang = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		_ang = Mathf.LerpAngle(_angI, _angF, Time.time);
		//transform.eulerAngles = new Vector3(0, _ang, 0);
		transform.rotation = Quaternion.Euler(0, _ang, 0); // Hace lo mismo
	}
}
