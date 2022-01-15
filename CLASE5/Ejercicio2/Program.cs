using System;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
             Dado un array de longitud fija 3. Crear la condifion logica 
            necesaria en un IF para determinar que los tres elementos en 
            este son distintos entre si y ademas distitnos de null. Ejemplos

            int? [] array = new int?[3]{1,2,3};
            Si son distintos

            int [] array = new int[3]{1,2,null};
            No son distintos

            int [] array = new int[3]{3,2,3};
            No son distitnos

            SOLO USAR IF, NO FOR. 
            1min 10.22
             */
            int?[] array = new int?[3] { 1, 2, null };

            if (array[0] != array[1] && array[0] != array[2] && array[1] != array[2] && array[0] != null && array[1] != null && array[2] != null)
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
