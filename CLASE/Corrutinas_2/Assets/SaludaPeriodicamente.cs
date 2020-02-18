using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaludaPeriodicamente : MonoBehaviour
{
    int saludos = 0;

    private bool flag;

    // Use this for initialization
    void Start()
    {
        flag = true;
        StartCoroutine(Saluda());
    }

    // Update is called once per frame
    void Update()
    {
        if (saludos == 10)
            flag = false;
    }

    IEnumerator Saluda()
    {
        Debug.Log("Hola Manifiest" + saludos++);
        yield return new WaitForSeconds(1);
        if (flag)
            StartCoroutine(Saluda());
    }
}