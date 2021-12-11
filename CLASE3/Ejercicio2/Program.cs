using System;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Ejercicio 2
             * Copiar el codigo del ejercicio anterior y realizar las siguiente 
             * modificaciones (refactorizar) PARA QUE TAMBIEN RESPONDA;
             * 1) Si el numero ingresado es 0, debe responder que no tiene paridad.
             * 2min 10.26Am
             */

            //1
            Console.WriteLine("Ingrese un nuemro");
            String numeroIngresado = Console.ReadLine();
            //2
            int numeroConvertido = Convert.ToInt32(numeroIngresado);
            //3
            int resto = numeroConvertido % 2;
            //4
            if(numeroConvertido != 0) { 
                if (resto == 0) //PAR
                {
                    Console.WriteLine("Es par");
                }
                else
                {
                    Console.WriteLine("Es imapar");
                }
            }
            else
            {
                Console.WriteLine("No tiene paridad.");
            }

        }
    }
}
