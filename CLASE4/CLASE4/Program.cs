using System;

namespace CLASE4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un valor");
            string valorIngresado = Console.ReadLine();
            int valorConvertido = Convert.ToInt32(valorIngresado);

            if(valorConvertido > 0)
            {
                Console.WriteLine("Es positivo");
            }
            else if(valorConvertido < 0)
            {
                Console.WriteLine("Es negativo");
            }
            else if(valorConvertido == 0)
            {
                Console.WriteLine("Es cero. No tiene signo");
            }
            else //Defualt
            {
                Console.WriteLine("Algo salio mal.");
            }

            int acumulador = 0;
            for(int i = 0; i < 20; i++)
            {
                Console.WriteLine(i);
                acumulador = acumulador + i;
            }
            Console.WriteLine(acumulador);
        }
    }
}
