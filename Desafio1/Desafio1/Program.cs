using System;

class totito
{
    static char[,] tablero = new char[3, 3];
    static int jugadorActual = 1;
    static bool juegoTerminado = false;

    static void Main()
    {
        InicializarTablero();
        while (!juegoTerminado)
        {
            DibujarTablero();
            RealizarJugada();
            ComprobarVictoria();
            CambiarJugador();
        }
    }

    private static void CambiarJugador()
    {
        throw new NotImplementedException();
    }

    static void InicializarTablero()
    {
        for (int fila = 0; fila < 3; fila++)
        {
            for (int columna = 0; columna < 3; columna++)
            {
                tablero[fila, columna] = '-';
            }
        }
    }

    static void DibujarTablero()
    {
        Console.Clear();
        Console.WriteLine("  1 2 3");
        for (int fila = 0; fila < 3; fila++)
        {
            Console.Write(fila + 1 + " ");
            for (int columna = 0; columna < 3; columna++)
            {
                Console.Write(tablero[fila, columna] + " ");
            }
            Console.WriteLine();
        }
    }

    static void RealizarJugada()
    {
        Console.WriteLine("Turno del jugador " + jugadorActual);
        Console.Write("Fila: ");
        int fila = int.Parse(Console.ReadLine()) - 1;
        Console.Write("Columna: ");
        int columna = int.Parse(Console.ReadLine()) - 1;
        if (tablero[fila, columna] == '-')
        {
            tablero[fila, columna] = (jugadorActual == 1) ? 'X' : 'O';
        }
        else
        {
            Console.WriteLine("Esa casilla ya está ocupada.");
            RealizarJugada();
        }
    }

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
