using System;

namespace Ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Dada una matrix, hacer el promedio de todos los valores 
             que hay en ella. 3min 12.53*/

            int[,] matrix = new int[2, 5] { { 1, 2, 3, 4, 5 }, { 7, 8, 11, 12, 13 } };

            int acumulador = 0;
            int conatador = 0;

            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j =0; j < matrix.GetLength(1); j++)
                {
                    acumulador = acumulador + matrix[i, j];
                    conatador++;
                }
            }

            int promedio = acumulador / conatador;
            Console.WriteLine(promedio);
        }
    }
}
