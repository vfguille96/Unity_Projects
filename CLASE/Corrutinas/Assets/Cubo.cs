using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubo : MonoBehaviour
{
    public float _velRot = 3;
    Vector3 _anguloRot;
    private float _fuerzaImpulso;

    // Use this for initialization
    void Start()
    {
        _anguloRot = new Vector3(0.33F, 0.33F, 0.33F);
        _fuerzaImpulso = 10;
        GetComponent<Rigidbody>().AddForce(Vector3.up * _fuerzaImpulso, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0.33F, 0.33F, 0.33F) * _velRot);
        gameObject.GetComponent<Renderer>().material.color = Random.ColorHSV();
    }
}