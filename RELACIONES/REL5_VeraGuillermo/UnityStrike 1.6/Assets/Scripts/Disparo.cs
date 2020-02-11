using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour
{
    private GameObject _gameObject;

    // Use this for initialization
    void Start()
    {
        _gameObject = GameObject.Find("w_pist_deagle");
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(DisparoEagle());
        /*if (Input.GetMouseButtonDown(0))
        {
            _gameObject.GetComponent<Animator>().enabled = true;
            _gameObject.GetComponent<Animator>().Play("Eagle2", 1, 1);
        }*/
    }

    private IEnumerator DisparoEagle()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _gameObject.GetComponent<AudioSource>().Play();
            _gameObject.GetComponent<Animator>().enabled = true;
            _gameObject.GetComponent<Animator>().Play("Eagle2", 0, 0.25F);
        }

        yield return null;
    }
}