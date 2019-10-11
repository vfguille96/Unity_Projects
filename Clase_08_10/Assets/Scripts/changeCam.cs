using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeCam : MonoBehaviour
{

	public GameObject cam1;
	public GameObject cam2;
 
	 void Start() {
		cam1.SetActive(true); 
		cam2.SetActive(false);
	 }

	void Update()
	{

		if (Input.GetKeyDown(KeyCode.C))
		{
			cam1.active = !cam1.active;
			cam2.active = !cam2.active;
		}
	}
}
