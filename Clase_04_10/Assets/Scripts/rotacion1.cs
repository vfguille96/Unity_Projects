using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotacion1 : MonoBehaviour
{
    public GameObject _objetoDestino;
    public float _vel = 0.01F;
    private float mitades;
    

    // Use this for initialization
    void Start()
    {
        mitades = _objetoDestino.transform.localScale.z / 2 + transform.localScale.z / 2;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            var position = transform.position;
            var position1 = _objetoDestino.transform.position;
            position = Vector3.MoveTowards(position, new Vector3(position1.x,
                position.y, position1.z + mitades), _vel);
            transform.position = position;
        }
    }
}