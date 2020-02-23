using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class MoverJugador : MonoBehaviour
{
    private Rigidbody _rigidbody;
    public float _vel;
    public float _salto;
    public GameObject _camara;
    private GameObject _cuerpo;
    private RaycastHit[] HitInfo;
    public float timeoutTime = 0.5f;
    private float timeCounter;
    private bool hitSet;

    [HideInInspector] public Vector2 RunAxis;

    // Use this for initialization
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _cuerpo = GameObject.Find("arctic_Armature");
        timeCounter = 0.0f;
        hitSet = false;
    }

    // Update is called once per frame
    void Update()
    {
        BloquearRotacionEjeZJugador();
        RotarCuerpoPersonaje();
        Salto();
    }

    /// <summary>
    /// Rotación del cuerpo del personaje respecto a la cámara.
    /// </summary>
    private void RotarCuerpoPersonaje()
    {
        _cuerpo.transform.localEulerAngles = new Vector3(-90, _camara.transform.localEulerAngles.y + 180, 0);
    }

    /// <summary>
    /// Bloqueo de la rotación del jugador en el eje Z.
    /// </summary>
    private void BloquearRotacionEjeZJugador()
    {
        transform.eulerAngles = new Vector3(transform.rotation.x, transform.rotation.y, 0);
    }

    /// <summary>
    /// Salto del jugador. Se aplica una fuerza física.
    /// Se comprueba que la distancia del jugador con el suelo a través de un Rayo.
    /// </summary>
    private void Salto()
    {
        timeCounter += Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.Space) && !GameController.TiempoPausado || FixedButtonSalto.Pressed && !GameController.TiempoPausado && !hitSet)
        {
            hitSet = true;
            var position = transform.position;
            Debug.DrawRay(position, Vector3.down * 10, Color.green);
            HitInfo = Physics.RaycastAll(position, Vector3.down * 10);

            if (HitInfo[0].collider.name.Equals("dust2_map") &&
                HitInfo[0].distance < GameController.DISTANCIA_MAX_SUELO_SALTO)
            {
                Debug.Log(HitInfo[0].collider.name);
                Debug.Log(HitInfo[0].distance);
                _rigidbody.AddForce(transform.up * _salto);
            }
        }
        
        if(timeCounter > timeoutTime)
        {
            timeCounter = 0.0f;
            hitSet = false;
        }
    }

    private void FixedUpdate()
    {
        MoverJugadorTeclas();
    }

    /// <summary>
    /// Movimiento del jugador resperco al "forward" de la cámara.
    /// </summary>
    private void MoverJugadorTeclas()
    {
        _rigidbody.MovePosition(transform.position + _camara.transform.forward * (RunAxis.y * _vel) +
                                _camara.transform.right * (RunAxis.x * _vel));
    }

    /// <summary>
    /// Lógica de munición.
    /// </summary>
    /// <param name="other">Objeto impactado en la colisión.</param>
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Municion"))
        {
            if (GameController.BalasTotales <= 35)
            {
                other.gameObject.GetComponent<AudioSource>().Play();
                if (GameController.BalasCargador == 0)
                {
                    GameController.BalasCargador += 7;
                    GameController.BalasTotales += 7;
                }
                else
                {
                    GameController.BalasRestantes += 7;
                    GameController.BalasTotales += 7;
                }

                Destroy(other.gameObject, 0.5F);
            }
        }
    }
}