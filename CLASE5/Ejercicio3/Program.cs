using System;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Dada una matrix de dimension fija 3x3. Armar un programa que determine si los
            componenetes de cada fila de la matrix son distinos entre si. Utilizar un if anidado en 
            un for. Ejemplos

            int? [,] matrix = new int? [3,3]{{1,2,3},{3,3,3},{2,null,3}};

            El resultado deberia ser;
            - Son distintos
            - No son distitnos
            - No son distintos
            2min 10.35AM
             */

            int?[,] matrix = new int?[3, 3] { { 1, 2, 3 }, { 3, 3, 3 }, { 2, null, 3 } };

            //1 IF comprobando como ejemplo que funcione en una fila - (Ejercicio 2)
            /*if (matrix[0,0] != matrix[0,1] && matrix[0,0] != matrix[0,2] && matrix[0,1] != matrix[0,2] && matrix[0,0] != null && matrix[0,1] != null && matrix[0,2] != null)
            {
                Console.WriteLine("Son distintos");
            }
            else
            {
                Console.WriteLine("No son distintos");
            }*/

            //2 For

            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                if (matrix[i, 0] != matrix[i, 1] && matrix[i, 0] != matrix[i, 2] && matrix[i, 1] != matrix[i, 2] && matrix[i, 0] != null && matrix[i, 1] != null && matrix[i, 2] != null)
                {
                    Console.WriteLine("Son distintos");
                }
                else
                {
                    Console.WriteLine("No son distintos");
                }
            }

        }
    }
}
