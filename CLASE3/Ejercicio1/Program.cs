using System;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Ejercicio 1
             * 
             * Realizar un programa que:
             * 1) Solicite al usuario ingresar un numero por consola.
             * 2) Convertir el ingreso a tipo numerico.
             * 3) Hacer la operacion del resto (%) con un 2.
             * 4) Determinar si el numero es par o impar. 
             * 
             * NOTA: Al hacer la operacion del resto con un 2, si el resultado 0 es porque el numero
             * es par, si no es impar. Ejemplos; 
             * 8 % 2 = 0 -> Par
             * 9 % 2 = 1 -> Impar
             * 3 % 2 = 1 -> Impar
             * 4 % 2 = 0 -> Par
             * 
             * 3min 10.18AM
             */

            //1
            Console.WriteLine("Ingrese un nuemro");
            String numeroIngresado = Console.ReadLine();
            //2
            int numeroConvertido = Convert.ToInt32(numeroIngresado);
            //3
            int resto = numeroConvertido % 2;
            //4
            if(resto == 0) //PAR
            {
                Console.WriteLine("Es par");
            }
            else
            {
                Console.WriteLine("Es imapar");
            }


        }
    }
}
