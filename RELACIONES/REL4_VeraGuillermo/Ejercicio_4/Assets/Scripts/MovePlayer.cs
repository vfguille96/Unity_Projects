using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MovePlayer : MonoBehaviour {
	private float _vel;
	private Vector3 _dir;
	private int _fruit = 0;
	private TextMeshProUGUI _text;

	// Use this for initialization
	void Start ()
	{
		_vel = 250;
		_text = GameObject.Find("TextMeshPro Text").GetComponent<TextMeshProUGUI>();
	}

	private void Update()
	{
		_dir = new Vector3(
			Input.GetAxis("Horizontal") * _vel * Time.deltaTime, 
			GetComponent<Rigidbody>().velocity.y, 
			Input.GetAxis("Vertical") * _vel * Time.deltaTime);
		transform.LookAt(transform.position + new Vector3(_dir.x, 0, _dir.z));
	}

	private void FixedUpdate()
	{
		GetComponent<Rigidbody>().velocity = _dir;


		/*GetComponent<Transform>().Rotate(new Vector3(transform.rotation.x, Input.GetAxis("Mouse X"), transform.rotation.z));
		if (Input.GetKeyDown(KeyCode.W))
			GetComponent<Rigidbody>().AddForce(new Vector3(transform.position.x * _vel, 0, transform.position.z * _vel) * _vel, ForceMode.Impulse);
			*/


		/*if (Input.GetKeyDown(KeyCode.S))
			GetComponent<Rigidbody>().AddForce(Vector3.back * _vel, ForceMode.Impulse);
		if (Input.GetKeyDown(KeyCode.A))
			GetComponent<Rigidbody>().AddForce(Vector3.left * _vel, ForceMode.Impulse);
		if (Input.GetKeyDown(KeyCode.D))
			GetComponent<Rigidbody>().AddForce(Vector3.right * _vel, ForceMode.Impulse);*/

	}

	private void OnCollisionStay(Collision other)
	{
		if (other.gameObject.tag.Equals("Malacatoneh"))
		{
			_fruit++;
			Destroy(other.gameObject);
			_text.text = "Melocotones: " + _fruit;
		}
	}
}
