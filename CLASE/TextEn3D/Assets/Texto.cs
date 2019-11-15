﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Texto : MonoBehaviour
{
	private string texto =
		"Me cago en todos los muertos de tu árbol genealógico, y si me apuras también en los vivos, puto amorfo de mierda. " +
		"\nTe pillo por la calle y te hundo el pecho a martillazos, enfermo hijo de la gran puta. " +
		"\nSi tienes hijos espero que tengan alguna discapacidad física o mental, o en su defecto los atropelle un autobús. " +
		"\nPero que no mueran, que sufran toda su puta vida, y si no tienes hijos nunca, que será lo que pasará seguramente, " +
		"\nDios te bendiga con una gordaca puto follapinos hijo de la gran puta." +
		"\nComo me entere de que me reportas otra vez con alguna cuenta así, y me entere de quién eres, te juro que te busco, " +
		"\ny cuando te encuentre te voy a ir quitando partes de tu ridículo cuerpo y me las voy a ir comiendo. " +
		"\nMientras me las como las cagaré y te haré comer mis putas heces con trocitos de tu piel rebozados. " +
		"\nCuando ya te haya destripado completamente y te haya hecho comer toda la mierda que suelte de mi precioso " +
		"\ny brillante culo iré a por tu hermana, y si no tienes hermana iré a por la sudada de tu puta madre, " +
		"\ny si voy inspirado iré a por las dos. Las secuestraré, las meteré en una furgoneta, las llevaré a una habitación, " +
		"\nles meteré el rabo por todos los agujeros de su cuerpo (incluidos los de la nariz y orejas), " +
		"\nme correré dentro de ellas y esperaré 9 meses a que nazcan sus hijas, y cuando cumplan 13 años me las follaré también. " +
		"\nY si después de eso te siguen quedando primas o tías, haré lo mismo con ellas, y cuando ya esté cansado de follarme " +
		"\na toda tu familia de piojosos cogeré unas cuantas cadenas, las pondré en mi coche y recorreré 300 km con toda tu " +
		"\nfamilia enganchada a ellas. Si después de eso queda alguien vivo, les echo alcohol para que rabien aún más de dolor. " +
		"\nDespués de todo eso, iré al hospital cuando ya te hayas recuperado del destripamiento que te hice. Te sacaré de ahí, " +
		"\nte llevaré a la misma habitación donde me follé a todas las mujeres de tu actual familia y a las que preceden en tu " +
		"\nárbol genealógico, y mientras te pongo los videos de cómo me follaba a tu madre, te daré minipollazos en la frente hasta " +
		"\nque se te quede la marca de mi grande y devastador glande para el resto de tu vida. Así, cada vez que te mires en el espejo, " +
		"\nrecordarás esos vídeos y lo que hice con tu familia. Después de eso te soltaré y volveré a ir a por ti a los tres meses. " +
		"\nTe volveré a meter en la habitación, pero esta vez nada suave, esta vez cogeré tus manos y empezare a meterte agujas entre " +
		"\nlas uñas hasta que el nivel de dolor te haga desmayarte y tenga que reanimarte con un desfibrilador. Te bajaré los pantalones " +
		"\ny los calzoncillos y empezaré a darte minimartillazos en tus cojones hasta que poco a poco se vayan deshaciendo y tu escroto " +
		"\nquede completamente vano. Imagino que después de eso te desmayarás otra vez, pues volveré a usar el desfibrilador para reanimarte. " +
		"\nMeteré tus pies en un cubo con agua, te pondré pinzas en los pezones, pene y lengua y te daré descargas hasta que vuelvas a desmayarte. " +
		"\nCuando lo hagas ya sabes lo que haré, y volveré y cogeré unas tenazas e iré arrancando una a una tus putas uñas pedazo de escoria. " +
		"\nDespués te tumbaré, te pondré un trapo en la cara e iré echándote en la boca agua poco a poco sin que llegues a ahogarte. " +
		"\nDespués me iré y volveré cada a día para hacerte una tortura diferente, para que cada vez que oigas mis pasos acercándose a la puerta, " +
		"\na horas diferentes de cada día, sientas que un miedo que jamás has experimentado recorra tu cuerpo. Me quedaré en la puerta haciendo " +
		"\ncomo que abro hasta que te mees encima, entonces entraré y comenzaré. Cuando vea que ya no das para más torturas dejaré que te cures " +
		"\nen un hospital y volveré a ir a por ti cuando te recuperes. Te cogeré y mientras te quemo los ojos con un soplete te daré martillazos " +
		"\nen la nuez hasta que mueras pedazo de hijo de la gran puta. Pero no pienses que todo acaba ahí. Si la reencarnación existe, " +
		"\nvolveré reencarnado en cualquier otra persona y te haré a ti y a toda tu nueva familia todo lo que te he hecho en esta vida, " +
		"\npero más lento y sin matarte, para que cada vez que vieses una sombra en la noche pienses que soy yo, para que te entre una " +
		"\nlocura impresionante y caigas en un estado vegetativo simplemente del miedo que te causa mi presencia. Si te curan, ya no volveré " +
		"\na ir más a por ti, morirás viejo, solo, sin huevos, sin piel y espérate a que no te corte las piernas desecho de mierda.";

	public float _vel = 2;
	
	// Use this for initialization
	void Start ()
	{
		GetComponent<TextMesh>().text = texto;
	}
	
	// Update is called once per frame
	void Update ()
	{
		Vector3 pos = transform.position;
		Vector3 localVectorUp = transform.TransformDirection(Vector3.up);
		pos += localVectorUp * _vel * Time.deltaTime;
		transform.position = pos;
	}

	private void OnGUI()
	{
		Rect pos = new Rect(20, 10, 150, 40);
		Rect pos2 = new Rect(20, 60, 150, 40);
		if (GUI.Button(pos, "On/Off"))
		{
			if (_vel != 0)
				_vel = 0;
			else
				_vel = 2;
		}

		if (GUI.Button(pos2, "Invertir"))
		{
			if (_vel != -2)
				_vel = -2;
			else
				_vel = 2;
		}
	}
	
	//Application.persistentDataPath
}
