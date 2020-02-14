using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Emisor : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            GameObject.FindWithTag("Receptor").SendMessage("Accion", "Soy el emisor");
        }

        if (Input.GetMouseButtonDown(1))
        {
            GameObject.FindWithTag("Receptor").BroadcastMessage("Accion", "");
        }
    }
}