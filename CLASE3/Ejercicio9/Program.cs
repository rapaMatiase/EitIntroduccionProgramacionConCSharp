using System;

namespace Ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            /*EJERCICIO 9
             * Realizar un programa que calcule el promedio de 0 hasta N, 
             * siendo N un numero positivo ingresado por el usuario.
             * 2min 11.35AM
             */
            int sumatoria = 0;
            int promedio = 0;
            int N = 0;

            Console.WriteLine("Ingrese un numero");
            String nIngresado = Console.ReadLine();
            N = Convert.ToInt32(nIngresado);

            for (int i = 0; i <= N; i++)
            {
                sumatoria = sumatoria + i;
            }
            promedio = sumatoria / N;
            Console.WriteLine("Pormedio  :" + promedio);
        }
    }
}
