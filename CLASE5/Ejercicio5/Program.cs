using System;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Dada una matrix determinar si todas las columnass estan compuestas por elemenos 
            distintos. Reutilizar el codigo del ejercicio anteriror y modificar.
            1 min 11.05 Pensar en la estrategia
            2 min 11.08   Resolver
             */

            int?[,] matrix = new int?[3, 3] { { 1, 2, 3 }, { 3, 3, 2 }, { 2, 1, 1 } };

            Boolean banderaTodasLasColumnasSonDistintas = true;
            for (int j = 0; j < matrix.GetLength(0); j++)
            {
                if (matrix[0, j] != matrix[1, j] && matrix[0, j] != matrix[2, j] && matrix[1, j] != matrix[2, j] && matrix[0, j] != null && matrix[1, j] != null && matrix[2, j] != null)
                {
                    continue;
                }
                else
                {
                    banderaTodasLasColumnasSonDistintas = false;
                }
            }

            Console.WriteLine(banderaTodasLasColumnasSonDistintas);
        }
    }
}
