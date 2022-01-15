using System;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Dado una matrix. Determinar que todas las filas estan compuestas por elemenos distintos.
            Utilizar el codigo del ejercicio anterio, modificar agregando un acumulador de booleanos o 
            bandera.
            2min 10.59
             */

            int?[,] matrix = new int?[3, 3] { { 1, 2, 3 }, { 1, 3, 2 }, { 2, 1, 3 } };

            Boolean banderaTodasLasFilasSonDistintas = true;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                if (matrix[i, 0] != matrix[i, 1] && matrix[i, 0] != matrix[i, 2] && matrix[i, 1] != matrix[i, 2] && matrix[i, 0] != null && matrix[i, 1] != null && matrix[i, 2] != null)
                {
                    continue;
                }
                else
                {
                    banderaTodasLasFilasSonDistintas = false;
                }
            }

            Console.WriteLine(banderaTodasLasFilasSonDistintas);
        }
    }
}
