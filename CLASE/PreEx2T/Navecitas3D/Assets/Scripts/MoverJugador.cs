using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverJugador : MonoBehaviour
{
    public float _vel;

    // Use this for initialization
    void Start()
    {
        _vel = 30000;
    }

    // Update is called once per frame
    void Update()
    {
        transform.localPosition =
            new Vector3(-780, Mathf.Clamp(Input.GetAxis("Vertical") * _vel * Time.deltaTime, -400, 400), 0);
    }
}