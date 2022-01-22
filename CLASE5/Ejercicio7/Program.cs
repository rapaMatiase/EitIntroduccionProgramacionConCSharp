using System;

namespace Ejercicio7
{
    class Program
    {

        static String ControlarElementosDeArraySonDistintos(int [] array)
        {
            String resultado = "";
            if (array[0] != array[1] && array[0] != array[2] && array[1] != array[2])
            {
                resultado = "Son distintos";
            }
            else
            {
                resultado = "No son distintos";
            }
            return resultado;
        }
        static void Main(string[] args)
        {
            /*
             Utilizando el Ejercicio 1. Convertir el codigo en una funcion que 
                - Parametros; el array
                - Retorno ; el string con el resultado.
                2min 12.54
             */

            int[] array = new int[3] { 1, 2, 3 };
            int[] array2 = new int[3] { 1, 3, 3 };
            int[] array3 = new int[3] { 2, 2, 3 };

            String resultado = ControlarElementosDeArraySonDistintos(array);
            //Puedo utilizar la misma funcion varias veces con distintos o el mismo array.
            String resultado2 = ControlarElementosDeArraySonDistintos(array2);
            String resultado3 = ControlarElementosDeArraySonDistintos(array3);

            Console.WriteLine(resultado);
            Console.WriteLine(resultado2);
            Console.WriteLine(resultado3);

        }
    }
}
