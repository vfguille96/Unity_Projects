using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class ParpadeoLuzMunicion : MonoBehaviour
{
    public Light _light;

    // Rango Variables
    public bool cambiarRango = true;
    public float velocidadRango = 5.0f;
    public float maxRango = 5.0f;
    public bool repetirRango = true;

    // Intensidad Variables
    public bool cambiarIntensidad = true;
    public float velIntensidad = 2.0f;
    public float maxIntensidad = 3.0f;
    public bool repetirIntensidad = true;

    float _startTime;

    // Use this for initialization
    void Start()
    {
        _light = GetComponent<Light>();
        _startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (cambiarRango)
        {
            if (repetirRango)
                _light.range = Mathf.PingPong(Time.time * velocidadRango, maxRango);
            else
            {
                _light.range = Time.time * velocidadRango;
                if (_light.range >= maxRango)
                    cambiarRango = false;
            }
        }

        if (cambiarIntensidad)
        {
            if (repetirIntensidad)
                _light.intensity = Mathf.PingPong(Time.time * velIntensidad, maxIntensidad);
            else
            {
                _light.intensity = Time.time * velIntensidad;
                if (_light.intensity >= maxIntensidad)
                    cambiarIntensidad = false;
            }
        }
    }
}