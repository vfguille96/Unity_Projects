using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvionQuaternion : AvionEuler {

	

	protected override void AplicarRotacion()
	{
		Vector3 _rotActual = Vector3.zero;
		_rotActual.x = _rotEjeX;
		_rotActual.y = _rotEjeY;
		_rotActual.z = _rotEjeZ;

		Quaternion rotacion = Quaternion.Euler(_rotActual * (_velRot * Time.deltaTime));

		transform.rotation *= rotacion;
	}
}
