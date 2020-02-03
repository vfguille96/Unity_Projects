using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hodor1 : MonoBehaviour {

	// Use this for initialization
	public GameObject _GameObject;
	private float _posIniY;
	void Start ()
	{
		_posIniY = transform.position.y;
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log(Vector3.Distance(transform.position, _GameObject.transform.position));
		if (Vector3.Distance(transform.position, _GameObject.transform.position) < 15)
		{
			Debug.Log("ANTES " + transform.position);
			transform.position = new Vector3(transform.position.x, Mathf.Clamp(transform.position.y * 10 * Time.deltaTime, _posIniY, -6.0918F), transform.position.z);
			Debug.Log(transform.position);
		}
		else
		{
			transform.position = Vector3.MoveTowards(transform.position,
				new Vector3(transform.position.x, -13.26737F, transform.position.z), 10);
		}
	}
	
	
}
