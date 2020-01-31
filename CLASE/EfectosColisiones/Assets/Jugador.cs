using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    float vel = 0.8F;
    float posXAct;
    float posZAct;
    Vector3 posActObj;
    float max = 4;

    float min = -4;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        MoverJugador();
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag.Equals("Enemigo"))
        {
            other.gameObject.GetComponent<ParticleSystem>().Play();
        }
    }

    void MoverJugador()
    {
        posXAct = transform.position.x + (Input.GetAxis("Horizontal") * vel);
        posZAct = transform.position.z + (Input.GetAxis("Vertical") * vel);

        posActObj = new Vector3(Mathf.Clamp(posXAct, min, max), transform.position.y, Mathf.Clamp(posZAct, min, max));

        transform.position = posActObj;
    }
}