using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayFromCamera : MonoBehaviour
{
	private Ray _ray;
	private RaycastHit _raycastHit;
	private Camera _camera;

	// Use this for initialization
	void Start () {
		_ray = new Ray();
		_camera = GetComponent<Camera>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0))
		{
			_ray = _camera.ScreenPointToRay(Input.mousePosition);
			if (Physics.Raycast(_ray, out _raycastHit))
			{
				Debug.LogFormat("Detectado objeto {0}", _raycastHit.collider.name);

				GameObject o;
				(o = _raycastHit.collider.gameObject).GetComponent<Rigidbody>().useGravity = true;
				Destroy(o, 0.8F);
				
			}
		}
	}
}
