using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour {
	/**
	 * Hay 4 tipos de fuerzas, AddForce():
	 * 	1- Force: se aplica una fuerza continua, teniendo en cuenta la masa de objeto.
	 * 	2- Acceleration: aplica una fuerza continua, ignorando la masa.
	 * 	3- Impulse: aplica una fuerza instantánea, teniendo en cuenta la masa.
	 * 	4- VelociteChanged: aplica una fuerza instantánea, ignorando la masa.
	 */
	// Use this for initialization

	public float _vel = 50F;	// Debe ser más elevado, ya que con FixedUpdate() se ejecuta menos veces por segundo que en Update().
	private Rigidbody _rigidbody;
	private Vector3 _fuerzaEmpuje;
	void Start ()
	{
		_rigidbody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void FixedUpdate() {
		_fuerzaEmpuje = new Vector3(Input.GetAxis("Horizontal") * _vel * Time.deltaTime, 0, Input.GetAxis("Vertical") 
		                                                                                    * _vel * Time.deltaTime);
		_rigidbody.AddForce(_fuerzaEmpuje);
		//_rigidbody.freezeRotation = true;	 // Hace que se congele la rotación. (En veh de roá', es resbalá).
	}
}