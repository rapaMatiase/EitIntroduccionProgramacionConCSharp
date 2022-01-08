using System;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Dado un array buscar el numero mas chico en este. 2min 10.55*/
            int[] array = new int[] { 3, 4, 6, 6, 23, 5, 21, 24 };
            int menorNumero = 100;
            for(int i = 0; i < array.Length; i++)
            {
                if(array[i] < menorNumero)
                {
                    menorNumero = array[i];
                }
            }
            Console.WriteLine(menorNumero);
        }
    }
}
