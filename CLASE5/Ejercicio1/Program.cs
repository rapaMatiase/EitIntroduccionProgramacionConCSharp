using System;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
             Dado un array de longitud fija 3. Crear la condifion logica 
            necesaria en un IF para determinar que los tres elementos en 
            este son distintos entre si. Ejemplos

            int [] array = new int[3]{1,2,3};
            Si son distintos

            int [] array = new int[3]{1,2,2};
            No son distintos

            int [] array = new int[3]{3,2,3};
            No son distitnos

            SOLO USAR IF, NO FOR. 
            2min 10.15
             */
            int[] array = new int[3] {1, 2, 3 };

            if (array[0] != array[1] && array[0] != array[2] && array[1] != array[2])
            {
                Console.WriteLine("Son distintos");
            }
            else
            {
                Console.WriteLine("No son distintos");
            }

        }
    }
}
