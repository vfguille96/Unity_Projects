using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PerseguirJugador : MonoBehaviour
{
    Transform jugador;
    NavMeshAgent navMeshAgent;

    void Awake()
    {
        jugador = GameObject.FindGameObjectWithTag("Player").transform;
        navMeshAgent = transform.GetComponent<NavMeshAgent>();
        StartCoroutine(QuitarVidaJugador());
    }

    // Update is called once per frame
    void Update()
    {
        navMeshAgent.SetDestination(jugador.position);
        if (GameController.Vida <= 0)
            navMeshAgent.enabled = false;
    }

    private IEnumerator QuitarVidaJugador()
    {
        if (Vector3.Distance(transform.position, jugador.position) <= GameController.DISTANCIA_MIN_ATAQUE && !GameController.TiempoPausado && GameController.Vida > 0)
        {
            GameController.Vida -= GameController.ROBO_VIDA_L1;
            jugador.GetComponent<AudioSource>().Play();
        }
        yield return new WaitForSeconds(0.5F);
        StartCoroutine(QuitarVidaJugador());
    }
}