using System;

namespace BusquedaOrden
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10] { 4, 6, 1, 5, 2, 3, 0, 9, 8, 7 };

            /* BUSQUEDA DEL MAYOR VALOR EN EL ARRAY*/

            int? valorMasAlto = -1;//Porque no inicializo esta variable?
            for(int i = 0; i < array.Length; i++)
            {
                if(valorMasAlto < array[i])
                {
                    valorMasAlto = array[i];
                }
            }
            Console.WriteLine(valorMasAlto);
            //La solucion mas sencilla e ineficiente que existe


        }
    }
}
