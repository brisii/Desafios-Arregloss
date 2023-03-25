using System;

internal class TresEnRayaBase1
{

    static void ComprobarVictoria()
    {
        for (int jugador = 1; jugador <= 2; jugador++)
        {
            char marca = (jugador == 1) ? 'X' : 'O';
            if ((tablero[0, 0] == marca && tablero[0, 1] == marca && tablero[0, 2] == marca) ||
                (tablero[1, 0] == marca && tablero[1, 1] == marca && tablero[1, 2] == marca) ||
                (tablero[2, 0] == marca && tablero[2, 1] == marca && tablero[2, 2] == marca) ||
                (tablero[0, 0] == marca && tablero[1, 0] == marca && tablero[2, 0] == marca) ||
                (tablero[0, 1] == marca && tablero[1, 1] == marca && tablero[2, 1] == marca) ||
                (tablero[0, 2] == marca && tablero[1, 2] == marca && tablero[2, 2] == marca) ||
                (tablero[0, 0] == marca && tablero[1, 1] == marca && tablero[2, 2] == marca) ||
                (tablero[0, 2] == marca && tablero[1, 1] == marca && tablero[2, 0] == marca))
            {
                Console.WriteLine("¡El jugador " + jugador + " ha ganado!");
                juegoTerminado = true;
            }
        }
    }
}