class ejercicio
{

    static int reinas = 8;
    static int[] tablero = new int[reinas];
    
    static void ColocarReinas()
    {

        for (int fila = 0; fila < reinas; fila++)
        {
            for (int columna = 0; columna < reinas; columna++)
            {
                if (tablero[fila] == columna)
                    Console.Write("1 ");
                else
                    Console.Write("0 ");
            }
            Console.WriteLine();
        }
    }
    static bool LlamarReinas(int fila, int columna)
    {

       
        for (int i = 0; i < fila; i++)
        {
            if (tablero[i] == columna)
                return false;
            if (Math.Abs(tablero[i] - columna) == Math.Abs(i - fila))
                return false;
        }
        return true;
    }

    static bool Solucion(int fila)
    {

        if (fila == reinas)
        {

            ColocarReinas();
            return true;
        }

        for (int columna = 0; columna < reinas; columna++)
        {
            if (LlamarReinas(fila, columna))
            {
                tablero[fila] = columna;
                if (Solucion(fila + 1))
                    return true;
                tablero[fila] = -1; 
            }
        }

        return false;
    }

    static void Main()
    {
        for (int i = 0; i < reinas; i++)
        {
            tablero[i] = -1; 
        }
        
        if (!Solucion(0))
        {
            Console.WriteLine("error");
        }
        
    }
}



