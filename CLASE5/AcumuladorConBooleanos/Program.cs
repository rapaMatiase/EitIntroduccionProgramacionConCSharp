using System;

namespace AcumuladorConBooleanos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Repaso acumulador, caso particular sumatoria
            int sumatoria = 0;
            for (int i = 0; i < 10; i++)
            {
                sumatoria = sumatoria + i;
            }
            Console.WriteLine(sumatoria);


            //Acumulador booleano - Banderas o Flags

            int[] listado = new int[10] { 1, 3, 82, 3, 4, 56, 89, 6, 8, 33 };
            //Yo inicializo la bandera suponinedo que todos los elementos de la lista o matrix
            //Si cumplen con la condicion dada. En este caso, todos los numeros son mayores que 8.
            Boolean bandera = true;

            for (int i = 0; i < listado.Length; i++)
            {
                if(listado[i] < 8)
                {
                    bandera = false;
                }
            }
            Console.WriteLine(bandera);
        }        
    }
}
