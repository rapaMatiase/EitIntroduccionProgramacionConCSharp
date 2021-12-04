using System;

namespace IF_ANIDADOS
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * En Argentina se puede sacar el registro en las siguientes condiciones;
             * - Si tener 16 o 17 con permiso de tus papas.
             * - Si tener entre 18 lo podes sacar.
             * - Si tener mas de 65 solo lo podes sacar por un años.
             * - Cualqueir otro caso, no lo podes sacar.
             */
            //Solicito la edad
            string edad = Console.ReadLine();
            //Convertirla
            int edadConvertida = Convert.ToInt32(edad);

            //Particual a lo general.
            if(edadConvertida == 16 || edadConvertida == 17)
            {
                Console.WriteLine("Podes sacar el registro con permiso de tus papas");
            }
            else if (18 <= edadConvertida && edadConvertida <= 65)
            {
                Console.WriteLine("Podes sacar el registro");
            }
            else if (65 < edadConvertida)
            {
                Console.WriteLine("Podes sacarlo pero solo por un año");
            }
            else
            {
                Console.WriteLine("No lo podes sacar");
            }
        }
    }
}
