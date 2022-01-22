using System;

namespace CLASE6
{
    class Program
    {
        static int Sumar(int a, int b)
        {
            int suma = a + b;
            return suma;
        }
        static void Main(string[] args)
        {
            int resultado = Sumar(23, 23);
            Console.WriteLine(resultado);
        }
    }
}
