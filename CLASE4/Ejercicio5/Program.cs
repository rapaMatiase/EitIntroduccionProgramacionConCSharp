using System;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Dado dos arrays, se consideran iguales 
             si en la misma posicion tiene el mismo valor.
            Por ejemplo, los array [1,4] y [1, 4] son iguales porque
            en la posicion 0 ambos tienen el mismo valor, y lo mismo en 
            la posicion 1.
            Otro ejemplo, los array [1,4] y [4,1] no son iguales, poruqe 
            en la posicion 0 uno tiene 1 y el otro 4. 
            3min 11.04
             */
            int[] array1 = new int[] { 1, 4 };
            int[] array2 = new int[] { 1, 2 };

            Boolean sonIguales = true;
            for(int i = 0; i < array1.Length; i++)
            {
                if(array1[i] != array2[i])
                {
                    sonIguales = false;
                }
            }
            Console.WriteLine(sonIguales);

        }
    }
}
