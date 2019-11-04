using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * Asignado a la esfera para moverla dentro de unos límites.
 */
public class moverArea : MonoBehaviour
{
	private const float MIN = -5;
	private const float MAX = 5;
	public float _posX = 0;
	public float _posZ = 0;
	private float _vel = 10F;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		var transform1 = transform;
		_posX += Input.GetAxis("Horizontal") * _vel * Time.deltaTime;
		_posZ += Input.GetAxis("Vertical") * _vel * Time.deltaTime;
		
		// Controla los límites del movimiento
		_posX = Mathf.Clamp(_posX, MIN, MAX);
		_posZ = Mathf.Clamp(_posZ, MIN, MAX);
		transform1.position = new Vector3(_posX, transform1.position.y, _posZ);

	}
}
