using System;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Ejercicio 4
            * En Argentina solo se puede votar si tenes 16 o mas años. Mostrar
            * en pantalla un mensaje al usuario "Podes votar" si cumple con la condicion. Caso
            * contrario mostrar un mensajae diciendo "No podes votar".
            * 1min 12.09
            */
            //Solicito la edad
            Console.WriteLine("Ingrese su edad");
            String edad = Console.ReadLine();
            // Convertio
            int edadConvertida = Convert.ToInt32(edad);
            //Resulevo
            if (16 <= edadConvertida)
            {
                Console.WriteLine("Podes votar");
            }
            else
            {
                Console.WriteLine("No podes votar");
            }
        }
    }
}
