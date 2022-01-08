using System;

namespace Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Dos array de la misma longitud son iguales si estan compuestos
             por los mismos elementos independientemente del orden que tengan.
            
                Por ejemplo [1,2,3] y [3,1,2] son iguales, pero [1,3] y [3,2]
            no lo son.
            3min 11.57
             */

            int[] array1 = new int[3] { 1, 2, 3 };
            int[] array2 = new int[3] { 2, 1, 3 };

            Boolean SonIguales = true;
            for(int i = 0; i < array1.Length; i++)
            {
                int elementoSeleccionado = array1[i];
                Boolean aprece = false;
                for(int j = 0; j < array2.Length; j++)
                {
                    if(array2[j] == elementoSeleccionado)
                    {
                        aprece = true;
                    }
                }

                if (!aprece)
                {
                    SonIguales = false;
                }
            }

            Console.WriteLine(SonIguales);

        }
    }
}
