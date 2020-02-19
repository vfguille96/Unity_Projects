using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameController
{
    public static bool TiempoPausado { get; set; }

    public const float DISTANCIA_MAX_SUELO_SALTO = 1.2F;

    public const float DISTANCIA_MIN_ATAQUE = 1.5F;
    
    public static int NumeroEnemigosEliminados { get; set; }
    
    // Nivel 1
    public const int ROBO_VIDA_L1 = 15;
    
    public static int NumeroEnemigos_L1 { get; set; }
    
    // Nivel 2
    public const int ROBO_VIDA_L2 = 25;
    
    public static int NumeroEnemigos_L2 { get; set; }
    
    // Nivel 3
    public const int ROBO_VIDA_L3 = 35;
    
    public static int NumeroEnemigos_L3 { get; set; }

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