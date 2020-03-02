using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameController
{
	public static int NIVEL_ACTUAL = 1;
	
	public static int PUNTOS = 0;

	public static float VEL_LV1 = 400;
	
	public static float VEL_LV2 = 600;
	
	public static float VEL_LV3 = 800;
	
	public static float VEL_ACTUAL = VEL_LV1;

	public static void SumarPuntos(Collider2D collider)
	{
		switch (collider.gameObject.tag)
		{
			case "Enemy1":
				PUNTOS += 10;
				break;
			case "Enemy2":
				PUNTOS += 20;
				break;
			case "Enemy3":
				PUNTOS += 30;
				break;
		}
	}
	
	

}
