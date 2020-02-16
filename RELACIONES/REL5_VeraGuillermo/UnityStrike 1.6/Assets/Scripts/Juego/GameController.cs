using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameController
{
    public static bool TiempoPausado { get; set; }
    public static string NombreJugador { get; set; }

    public static string ApellidosJugador { get; set; }

    public static string EdadJugador { get; set; }

    // 7 / 35 --> 42
    public static int BalasCargador { get; set; }
    
    public static int BalasTotales { get; set; }
    
    public static int BalasRestantes { get; set; }
    
    public static int Vida { get; set; }
    
    public static float TiempoJuego { get; set; }
    
}