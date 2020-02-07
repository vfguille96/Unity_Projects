using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiarGravedad : MonoBehaviour
{
    private Vector3 _rotacion;
    private float _vel;
    public Light[] _luces = new Light[2];
    public List<GameObject> _objetos;
    public Transform[] _camaras;

    // Use this for initialization
    void Start()
    {
        _vel = 5;
        _rotacion = Vector3.left;
    }

    // Update is called once per frame
    void Update()
    {
        Rotar();
        Caer();
    }

    private void Rotar()
    {
        // 1ª forma de acceder a los componentes.
        GetComponent<Transform>().Rotate(_rotacion * _vel);

        if (Input.GetMouseButtonDown(0))
        {
            _vel++;
        }

        if (Input.GetMouseButtonDown(1))
        {
            _vel--;
        }
    }

    private void Caer()
    {
        // 2ª forma de acceder a los componentes.
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ((Rigidbody) GetComponent(typeof(Rigidbody))).useGravity = true;
            _vel = 0;
            GetComponent<Renderer>().material.color = Color.red;
        }
    }
}