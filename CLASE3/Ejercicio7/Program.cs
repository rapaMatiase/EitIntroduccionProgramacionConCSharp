using System;

namespace Ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Ejercicio7
             * Realizar la sumatoria de los numeros 1 al 100.
             * 2min 11.25AM
             */
            int sumatoria = 0;
            for(int i = 0; i <= 100; i++)
            {
                sumatoria = sumatoria + i;
            }
            Console.WriteLine(sumatoria);
        }
    }
}
