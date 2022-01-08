using System;

namespace Ejercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Dada una matrix de adyacencia de un digrafo. Donde si recorro
             la fila, en cada columna que haya un 1 representa que desde la 
            calle que representa esa fila se puede llegar a la ubicacion en la 
            columna. Buscar en la matrix aquellas posiciones en las cuales se puede
            ir y volver por el mismo camino. 3min 1.02*/

            int[,] matrix = new int[3, 3] { { 1, 0, 1 }, { 1, 0, 1 }, { 1, 0, 0 } };

            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    if(matrix[i,j] == matrix[j, i])
                    {
                        Console.WriteLine(i + " con " + j);
                    }
                }
            }
        }
    }
}
