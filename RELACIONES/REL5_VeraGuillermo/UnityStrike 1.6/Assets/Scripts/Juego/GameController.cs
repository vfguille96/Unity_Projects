using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameController
{
    // Posiciones de reaparición de enemigos.
    public static Vector3[] _respawn = {
        new Vector3(47.052F, 3.088F, -5.9F), 
        new Vector3(0, -1.47F, 0),
        new Vector3(-51.51F, -0.542F, -34.25207F),
        new Vector3(-58.15276F, 2.75F, 52.24474F),
        new Vector3(21.01F, -6.41F, 50.54603F),
        new Vector3(-25.22F, -0.535F, -36.77F),
        new Vector3(-24.92308F, -0.8F, 24.70155F)
    };
    
    public static int NivelActual { get; set; }
    
    public static bool TiempoPausado { get; set; }

    public const float DISTANCIA_MAX_SUELO_SALTO = 1.2F;

    public const float DISTANCIA_MIN_ATAQUE = 1.85F;
    
    public static int NumeroEnemigosEliminados { get; set; }
    
    // Nivel 1
    public const int ROBO_VIDA_L1 = 15;

    public static int NumeroEnemigos_L1 = 7;
    
    // Nivel 2
    public const int ROBO_VIDA_L2 = 25;
    
    public static int NumeroEnemigos_L2 = 14;
    
    // Nivel 3
    public const int ROBO_VIDA_L3 = 35;

    public static int NumeroEnemigos_L3 = 28;

    public static bool Disparo { get; set; }
    public static string NombreJugador { get; set; }

    public static string ApellidosJugador { get; set; }

    public static string EdadJugador { get; set; }

    // 7 / 35 --> 42
    public static int BalasCargador { get; set; }

    public static int BalasTotales { get; set; }

    public static int BalasRestantes { get; set; }

    public static int Vida { get; set; }

    public static float TiempoJuego { get; set; }

    public static float TiempoJuegoRestante { get; set; }
}