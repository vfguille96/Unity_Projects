using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour
{
    private GameObject _pistola;
    //private GameObject _camara;
    public AudioClip _recargar;
    public AudioClip _disparo;
    public AudioClip _noBalas;
    private bool _recargando;

    // Use this for initialization
    void Start()
    {
        _pistola = GameObject.Find("w_pist_deagle");
        //_camara = GameObject.Find("Main Camera");
        _recargando = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!GameController.TiempoPausado && !_recargando)
            StartCoroutine(DisparoEagle());
    }

    private IEnumerator DisparoEagle()
    {
        if (Input.GetMouseButtonDown(0) && GameController.BalasTotales > 0)
        {
            GameController.BalasCargador -= 1;
            GameController.BalasTotales -= 1;

            _pistola.GetComponent<AudioSource>().clip = _disparo;
            _pistola.GetComponent<AudioSource>().Play();
            _pistola.GetComponent<Animator>().enabled = true;
            _pistola.GetComponent<Animator>().Play("Eagle2", 0, 0.25F);

            if (GameController.BalasCargador == 0)
            {
                if (GameController.BalasTotales != 0)
                {
                    _pistola.GetComponent<Animator>().enabled = true;
                    _pistola.GetComponent<Animator>().Play("EagleRecargar", 0, 0.25F);
                    _pistola.GetComponent<AudioSource>().clip = _recargar;
                    _pistola.GetComponent<AudioSource>().Play();
                    _recargando = true;
                    yield return new WaitForSecondsRealtime(1.5F);
                    _recargando = false;
                }
                
                GameController.BalasCargador = 7;
                if (GameController.BalasRestantes != 0)
                    GameController.BalasRestantes -= 7;
            }

            if (GameController.BalasTotales == 0)
                GameController.BalasCargador = 0;
        }

        if (Input.GetMouseButtonDown(0) && GameController.BalasTotales == 0)
        {
            _pistola.GetComponent<AudioSource>().clip = _noBalas;
            _pistola.GetComponent<AudioSource>().Play();
        }

        yield return null;
    }
}