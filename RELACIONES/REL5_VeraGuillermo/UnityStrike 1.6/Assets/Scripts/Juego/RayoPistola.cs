using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayoPistola : MonoBehaviour
{
	RaycastHit[] HitInfo;
	
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update ()
	{

		Debug.DrawRay(transform.position, transform.forward * 900000, Color.red);
		HitInfo = Physics.RaycastAll(transform.position, transform.forward * 900000);

		foreach (var DETECTADO in HitInfo)
		{
			Debug.Log(GameController.Disparo);
			if (DETECTADO.collider.gameObject.tag.Equals("Enemigo") && GameController.Disparo)
			{
				Debug.Log(DETECTADO.collider.name);
				Debug.Log(DETECTADO.distance);
				Debug.Log(GameController.Disparo);
				Destroy(DETECTADO.collider.gameObject);
			
			}
		}

		/*if(Physics.Raycast(transform.position,transform.forward, out HitInfo, 10000.0f))
			Debug.DrawRay(transform.position, transform.forward * 10000.0f, Color.red);

		if (HitInfo.collider.gameObject.tag.Equals("Enemigo") && GameController.Disparo)
		{
			Debug.Log(HitInfo.collider.name);
			Debug.Log(GameController.Disparo);
			Destroy(gameObject);
			
		}*/
	}
}
