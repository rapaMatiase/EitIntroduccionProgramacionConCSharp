using System;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Ejercicio 5
            * En Argentina se puede votar segun el siguiente reglamento:
            * - Si tenes menos de 16, no podes votar.
            * - Si tener 16 o 17, podes votar pero no es obligatorio.
            * - Si tener 18 o mas, podes votar y es obligatorio.
            * - Si tener mas de 70, podes votar y no es obligatorio. 
            * 3min 12.30AM
            */
            //Solicito la edad
            string edad = Console.ReadLine();
            //Convertirla
            int edadConvertida = Convert.ToInt32(edad);

            if(edadConvertida == 16 || edadConvertida == 17)
            {
                Console.WriteLine("Podes votar pero no es obligatorio");
            }
            else if (18 <= edadConvertida && edadConvertida <= 70)
            {
                Console.WriteLine("Podes votar y es obligatorio");
            }
            else if(70 < edadConvertida)
            {
                Console.WriteLine("Podes votar pero no es obligatorio");
            }
            else
            {
                Console.WriteLine("No podes votar.");
            }
        }
    }
}
