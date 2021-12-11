using System;

namespace Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Ejericio 6
             * Mostrar en pantalla los numeros pares entre 1 al 1000 sin utilizar un IF, solo FOR.
             * 2min 11.11AM
             
             */

            for(int i = 0; i <= 1000; i = i + 2)
            {
                Console.WriteLine(i);
            }

            //El mismo problema pero aplicando un if anidado en el for. Mejor la solucion de arriba.
            int resto = 0;
            for(int i = 0; i <= 1000; i++)
            {
                resto = i % 2;
                if(resto == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
