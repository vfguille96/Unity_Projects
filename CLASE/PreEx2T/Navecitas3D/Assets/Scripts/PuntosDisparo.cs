using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuntosDisparo : MonoBehaviour {
	private void OnTriggerEnter2D(Collider2D other)
	{
		GameController.SumarPuntos(other);
		if (!other.gameObject.tag.Equals("Player"))
		{
			Destroy(other.gameObject);
		}
	}
}
