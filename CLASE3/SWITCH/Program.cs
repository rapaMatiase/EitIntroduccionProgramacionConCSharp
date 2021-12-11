using System;

namespace SWITCH
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un nuemero del 1 al 3");
            String numeroIngresado = Console.ReadLine();

            switch (numeroIngresado)
            {
                case "1":
                    Console.WriteLine("Ingresaste un 1");
                    break;
                case "2":
                    Console.WriteLine("Ingresaste un 2");
                    break;
                case "3":
                    Console.WriteLine("Ingresaste un 3");
                    break;
                default:
                    Console.WriteLine("Defualt");
                    break;
            }
        }
    }
}
