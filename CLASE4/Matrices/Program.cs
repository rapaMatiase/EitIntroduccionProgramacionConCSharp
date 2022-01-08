using System;

namespace Matrices
{
    class Program
    {
        static void Main(string[] args)
        {
            //Con esto ya tengo una matrix
            int[,] matrix = new int[2, 2] { { 1, 2 }, { 3, 4 } };

            matrix[0, 1] = 66;

            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.WriteLine(matrix[i, j]);
                }
            }


        }
    }
}
