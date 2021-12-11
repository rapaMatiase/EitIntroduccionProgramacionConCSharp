using System;

namespace Ejercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Ejercicio8
             * Realizar un programa que determine el promedio de los numeros entre 8 y 70.
             * promedio = (sumatoria 8 y 70) / (70 - 8) 
             * 2min 11.29
             */
            int sumatoria = 0;
            int promedio = 0;
            for(int i = 8; i <= 70; i++)
            {
                sumatoria = sumatoria + i;
            }
            promedio = sumatoria / (70 - 8);
            Console.WriteLine("Pormedio  :" + promedio);
                
        }
    }
}
