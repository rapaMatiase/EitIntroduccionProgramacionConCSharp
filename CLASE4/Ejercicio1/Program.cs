using System;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Dado un array imprmir en pantalla pero al revez.
             Si el array es [1,2,3] en pantalla debe salir;
            3
            2
            1
            2min 10.34
            */
            int[] array = new int[3] {1,2,3};


            for(int i = array.Length - 1; 0 <= i ; i--)
            {
                Console.WriteLine(array[i]);
            }


        }
    }
}
