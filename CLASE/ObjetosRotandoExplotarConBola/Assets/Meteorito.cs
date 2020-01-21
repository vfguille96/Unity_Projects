using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteorito : MonoBehaviour
{
    private const float _VEL = 2;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(_VEL, _VEL, _VEL));
    }
}