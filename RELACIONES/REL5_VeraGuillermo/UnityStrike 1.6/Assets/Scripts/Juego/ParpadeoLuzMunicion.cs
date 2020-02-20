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

    // Use this for initialization
    void Start()
    {
        _light = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        if (cambiarRango)
        {
            if (repetirRango)
                _light.range = Mathf.PingPong(Time.timeSinceLevelLoad * velocidadRango, maxRango);
            else
            {
                _light.range = Time.timeSinceLevelLoad * velocidadRango;
                if (_light.range >= maxRango)
                    cambiarRango = false;
            }
        }

        if (cambiarIntensidad)
        {
            if (repetirIntensidad)
                _light.intensity = Mathf.PingPong(Time.timeSinceLevelLoad * velIntensidad, maxIntensidad);
            else
            {
                _light.intensity = Time.timeSinceLevelLoad * velIntensidad;
                if (_light.intensity >= maxIntensidad)
                    cambiarIntensidad = false;
            }
        }
    }
}