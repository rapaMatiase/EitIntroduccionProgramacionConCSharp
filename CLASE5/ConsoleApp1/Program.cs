using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Arrays vacio
            int[] arrayDeNumeros = new int[4];
            //Arrays con valores
            int[] arrayDeNumerosConValores = new int[4] {1,3,4,3};

            //Las posiciones en el array arrancan a contarce en 0
            //La primera posicion es la 0
            Console.WriteLine("0: " + arrayDeNumerosConValores[0]);
            
            //La segunda posicion es la 1
            Console.WriteLine("1: " + arrayDeNumerosConValores[1]);

            //La tercera posicion es la 2
            Console.WriteLine("2: " + arrayDeNumerosConValores[2]);

            //La cuarta posicion es la 3
            Console.WriteLine("3: " + arrayDeNumerosConValores[3]);

            //El mismo resultado de forma no HARDCODEADA.
            for(int i = 0; i < arrayDeNumerosConValores.Length; i++)
            {
                Console.WriteLine(i + ": " + arrayDeNumerosConValores[i]);
            }

            //REPASO DE MATRICES !!!

            //Declarar una matrix es como declarar un array de multiples dimensiones.
            int[,] matrix = new int[2, 2] { { 1, 2 }, { 3, 4 } };

            //Si quiero ver el contenido de cada celda en la matrix
            Console.WriteLine("i:" + 0 + "j:" + 0 + "->" + matrix[0,0]);
            Console.WriteLine("i:" + 0 + "j:" + 1 + "->" + matrix[0, 1]);
            Console.WriteLine("i:" + 1 + "j:" + 0 + "->" + matrix[1, 0]);
            Console.WriteLine("i:" + 1 + "j:" + 1 + "->" + matrix[1, 1]);

            //No HARDCODEO 

            //GetLenght -> Me devuelve el tamaño de la dimension.
            // 0 -> Es las filas o X
            // 1 -> Es las columnas o Y
            // 2 -> Es la profundidad o Z
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.WriteLine("i:" + i + "j:" + j + "->" + matrix[i, j]);
                }
            }

        }
    }
}
