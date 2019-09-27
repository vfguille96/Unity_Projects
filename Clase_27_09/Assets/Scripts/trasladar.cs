using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Enlazado al cubo.
public class trasladar : MonoBehaviour
{
    private float vel = 0.2F;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        // Mueve el cubo a la izquierda o derecha al pulsar las flechas.
        transform.Translate(Input.GetAxis("Horizontal") * vel, 0F, Input.GetAxis("Vertical") * vel);

        if (Math.Abs(Input.GetAxis("Fire1")) > 0)
            Debug.Log("Disparando");
    }
}