using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour
{
    private GameObject _pistola;
    public GameObject _particula;
    private Transform _camera;
    public AudioClip _recargar;
    public AudioClip _disparo;
    public AudioClip _noBalas;
    private AudioSource _audioPistola;
    private Animator _animacionPistola;
    private RaycastHit[] HitInfo;
    private bool _recargando;
    private bool _zoom;

    // Use this for initialization
    void Start()
    {
        _pistola = GameObject.Find("w_pist_deagle");
        _camera = GameObject.Find("Main Camera").GetComponent<Camera>().transform;
        _audioPistola = _pistola.GetComponent<AudioSource>();
        _animacionPistola = _pistola.GetComponent<Animator>();
        _recargando = false;
        _zoom = false;
        _particula.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        // Se produce un disparo cuando el tiempo no está pausado y no se está recargando.
        if (!GameController.TiempoPausado && !_recargando)
            StartCoroutine(DisparoEagle());

        if (Input.GetMouseButtonDown(1))
            ZoomApuntar();
    }

    /// <summary>
    /// Zoom de la cámara para apuntar.
    /// </summary>
    private void ZoomApuntar()
    {
        if (!_zoom)
        {
            _camera.GetComponent<Camera>().fieldOfView = 40;
            _zoom = true;
        }
        else
        {
            _camera.GetComponent<Camera>().fieldOfView = 60;
            _zoom = false;
        }
    }

    private IEnumerator DisparoEagle()
    {
        if (Input.GetMouseButtonDown(0) && GameController.BalasTotales > 0)
        {
            int i = 0;
            GameController.Disparo = true;
            var position = _camera.position;
            var forward = _camera.forward;
            Debug.DrawRay(position, forward * 100, Color.red);
            HitInfo = Physics.RaycastAll(position, forward * 100);

            Debug.Log(GameController.Disparo);

            if (HitInfo.Length != 0)
            {
                foreach (var ENEMIGO in HitInfo)
                {
                    if (ENEMIGO.collider.gameObject.tag.Equals("Enemigo") && !_recargando)
                    {
                        Debug.Log(ENEMIGO.collider.name);
                        Debug.Log(ENEMIGO.distance);
                        Debug.Log(GameController.Disparo);
                        ENEMIGO.collider.gameObject.GetComponent<AudioSource>().Play();
                        Destroy(ENEMIGO.collider.gameObject, 0.1F);
                    }

                    Debug.Log("[" + i++ + "] PRUEBAAA: " + ENEMIGO.collider.name);
                }
            }

            // Sonido y animación de disparo.
            _audioPistola.clip = _disparo;
            _audioPistola.Play();
            StartCoroutine(ParticulaFuego());
            _animacionPistola.enabled = true;
            _animacionPistola.Play("Eagle2", 0, 0.25F);

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
                    _animacionPistola.enabled = true;
                    _animacionPistola.Play("EagleRecargar", 0, 0.25F);
                    _audioPistola.clip = _recargar;
                    _audioPistola.Play();

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
            _audioPistola.clip = _noBalas;
            _audioPistola.Play();
        }

        GameController.Disparo = false;
        yield return null;
    }

    /// <summary>
    /// Corrutina que es ejecutada cuando se produce un disparo.
    /// Partícula de fuego.
    /// </summary>
    /// <returns>WaitForSeconds()</returns>
    private IEnumerator ParticulaFuego()
    {
        _particula.SetActive(true);
        yield return new WaitForSeconds(0.07F);
        _particula.SetActive(false);
    }
}