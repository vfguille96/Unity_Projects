using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour
{
    private GameObject _pistola;
    public AudioClip _recargar;
    public AudioClip _disparo;
    public AudioClip _noBalas;
    private bool _recargando;

    // Use this for initialization
    void Start()
    {
        _pistola = GameObject.Find("w_pist_deagle");
        _recargando = false;
    }

    // Update is called once per frame
    void Update()
    {
        // Se produce un disparo cuando el tiempo no está pausado y no se está recargando.
        if (!GameController.TiempoPausado && !_recargando)
            StartCoroutine(DisparoEagle());
    }

    private IEnumerator DisparoEagle()
    {
        if (Input.GetMouseButtonDown(0) && GameController.BalasTotales > 0)
        {
            // Sonido y animación de disparo.
            _pistola.GetComponent<AudioSource>().clip = _disparo;
            _pistola.GetComponent<AudioSource>().Play();
            _pistola.GetComponent<Animator>().enabled = true;
            _pistola.GetComponent<Animator>().Play("Eagle2", 0, 0.25F);
            
            // Resta una bala.
            GameController.BalasCargador -= 1;
            GameController.BalasTotales -= 1;

            // Sonido y animación de recarga.
            if (GameController.BalasCargador == 0)
            {
                if (GameController.BalasTotales != 0)
                {
                    _recargando = true;
                    yield return new WaitForSecondsRealtime(0.3F);
                    _pistola.GetComponent<Animator>().enabled = true;
                    _pistola.GetComponent<Animator>().Play("EagleRecargar", 0, 0.25F);
                    _pistola.GetComponent<AudioSource>().clip = _recargar;
                    _pistola.GetComponent<AudioSource>().Play();
                    
                    yield return new WaitForSecondsRealtime(1.5F);
                    _recargando = false;
                }

                // Resta las BalasCargador a las BalasRestantes.
                GameController.BalasCargador = 7;
                if (GameController.BalasRestantes != 0)
                    GameController.BalasRestantes -= 7;
            }
            
            // Actualiza las BalasCargador cuando las BalasTotales son 0.
            if (GameController.BalasTotales == 0)
            {
                GameController.BalasCargador = 0;
                yield return new WaitForSecondsRealtime(0.5F);
            }
        }

        // No hay BalasTotales.
        if (Input.GetMouseButtonDown(0) && GameController.BalasTotales == 0)
        {
            _pistola.GetComponent<AudioSource>().clip = _noBalas;
            _pistola.GetComponent<AudioSource>().Play();
        }

        yield return null;
    }
}