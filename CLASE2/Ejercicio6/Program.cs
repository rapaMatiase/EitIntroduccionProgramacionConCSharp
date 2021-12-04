using System;

namespace Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Ejercicio 6
            * En Argentina se puede votar segun el siguiente reglamento:
            * - Si tenes menos de 16, no podes votar.
            * - Si tener 16 o 17, podes votar pero no es obligatorio.
            * - Si tener 18 o mas, podes votar y es obligatorio.
            * - Si tener mas de 70, podes votar y no es obligatorio. 
            * Controlar que el valor ingresado no sea menor e igual a 0.
            * 1min 12.45AM
            */
            //Solicito la edad
            string edad = Console.ReadLine();
            //Convertirla
            int edadConvertida = Convert.ToInt32(edad);

            if (edadConvertida > 0)
            {
                if (edadConvertida == 16 || edadConvertida == 17)
                {
                    Console.WriteLine("Podes votar pero no es obligatorio");
                }
                else if (18 <= edadConvertida && edadConvertida <= 70)
                {
                    Console.WriteLine("Podes votar y es obligatorio");
                }
                else if (70 < edadConvertida)
                {
                    Console.WriteLine("Podes votar pero no es obligatorio");
                }
                else
                {
                    Console.WriteLine("No podes votar.");
                }
            }
            else
            {
                Console.WriteLine("La edad debe ser un valor posirivo");
            }
        }
    }
}
