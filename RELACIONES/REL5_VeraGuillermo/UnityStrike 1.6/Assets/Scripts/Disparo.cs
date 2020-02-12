using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour
{
    private GameObject _pistola;
    private GameObject _camara;

    // Use this for initialization
    void Start()
    {
        _pistola = GameObject.Find("w_pist_deagle");
        _camara = GameObject.Find("Main Camera");
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(DisparoEagle());
    }

    private IEnumerator DisparoEagle()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _pistola.GetComponent<AudioSource>().Play();
            _pistola.GetComponent<Animator>().enabled = true;
            _pistola.GetComponent<Animator>().Play("Eagle2", 0, 0.25F);
        }

        yield return null;
    }
}