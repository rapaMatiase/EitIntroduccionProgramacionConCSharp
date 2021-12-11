using System;

namespace ACUMULADOR
{
    class Program
    {
        static void Main(string[] args)
        {
            int acumulador = 0; //En este caso la acumulacion es una sumatoria del 0 al 10.
            for(int i = 0; i <= 10; i++)
            {
                acumulador = acumulador + i;
                Console.WriteLine("i:" + i + ",acumulador:" + acumulador);
            }

        }
    }
}
