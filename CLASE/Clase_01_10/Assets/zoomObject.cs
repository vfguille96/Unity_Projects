using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zoomObject : MonoBehaviour
{
    private float zoomValue = 0;
    private float zoomIncrement = 2.5F;
    Quaternion _quaternion = new Quaternion(0, 0, 0, Single.Epsilon);
    Quaternion _quaternion2 = Quaternion.identity; // (0, 0, 0, 0)
    public GameObject _gameObject;
    
    // El operador * multiplica los valores de sus componentes.
    // El operador == evalúa cada componente y devuelve un bool.

    // Use this for initialization
    void Start()
    {
        // Crea una rotación instantánea.
        Quaternion.AngleAxis(zoomIncrement, Vector3.forward);
    }
    
    // Update is called once per frame
    void Update()
    {
        zoomValue = Input.GetAxis("Zoom");
        transform.localScale +=
            new Vector3(zoomIncrement * zoomValue, 
                        zoomIncrement * zoomValue, 
                        zoomIncrement * zoomValue)  * Time.deltaTime;
        
        transform.LookAt(_gameObject.transform);
        
    }
}