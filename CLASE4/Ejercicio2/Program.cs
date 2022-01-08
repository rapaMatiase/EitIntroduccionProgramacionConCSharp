using System;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Dado otro arreglo aplicar un acumulador que sume todos los numeros
             en el arreglo.2min 10.39am*/

            int[] arreglo = new int[5] { 2, 4, 62, 3, 4 };
            int acumulador = 0;
            for(int i = 0; i < arreglo.Length; i++)
            {
                acumulador = acumulador + arreglo[i];
            }
            Console.WriteLine(acumulador);
        }
    }
}
