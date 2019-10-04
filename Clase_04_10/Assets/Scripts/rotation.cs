using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation : MonoBehaviour
{
    private Quaternion _origen;
    private Quaternion _destino;
    public float _vel = 0F;

    // Use this for initialization
    void Start()
    {
        _origen = transform.rotation;
        _destino = Quaternion.Euler(0, 90, 0);
        _vel *= Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        _vel = Time.time * 0.1F;
        _origen = transform.rotation;
        //if (Input.GetKeyDown(KeyCode.Z))
        transform.rotation = Quaternion.Lerp(_origen, _destino, _vel);

        
        Debug.Log("Vel: " + _vel);
    }
}