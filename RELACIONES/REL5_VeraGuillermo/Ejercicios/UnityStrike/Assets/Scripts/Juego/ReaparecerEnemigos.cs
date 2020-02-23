using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReaparecerEnemigos : MonoBehaviour
{
    private int _numEnemigos;
    public GameObject _enemigo;
    private int _numPosiciones;
    private System.Random _random;

    // Use this for initialization
    void Start()
    {
        _numEnemigos = 0;
        _numPosiciones = GameController._respawn.Length;
        _random = new System.Random();
        StartCoroutine(ReaparecerEnemigosCorutina());
    }

    /// <summary>
    /// Corrutina de reaparición de enemigos.
    /// </summary>
    /// <returns></returns>
    private IEnumerator ReaparecerEnemigosCorutina()
    {
        if (GameController.NivelActual == 1)
        {
            while (_numEnemigos < GameController.NumeroEnemigos_L1 && !GameController.TiempoPausado)
            {
                Instantiate(_enemigo, GameController._respawn[_random.Next(_numPosiciones - 1)],
                    Quaternion.identity);
                _numEnemigos++;
                yield return new WaitForSecondsRealtime(GameController.TIEMPO_REAPARICION_L1);
            }
        }

        if (GameController.NivelActual == 2)
        {
            while (_numEnemigos < GameController.NumeroEnemigos_L2 && !GameController.TiempoPausado)
            {
                Instantiate(_enemigo, GameController._respawn[_random.Next(_numPosiciones - 1)],
                    Quaternion.identity);
                _numEnemigos++;
                yield return new WaitForSecondsRealtime(GameController.TIEMPO_REAPARICION_L1);
            }
        }

        if (GameController.NivelActual == 3)
        {
            while (_numEnemigos < GameController.NumeroEnemigos_L3 && !GameController.TiempoPausado)
            {
                Instantiate(_enemigo, GameController._respawn[_random.Next(_numPosiciones - 1)],
                    Quaternion.identity);
                _numEnemigos++;
                yield return new WaitForSecondsRealtime(GameController.TIEMPO_REAPARICION_L3);
            }
        }
    }
}