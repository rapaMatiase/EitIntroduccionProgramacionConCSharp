using System;

namespace Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            //String nombre = "Matias";
            //int edad = 22;
            //String formato = String.Format("Tu nombre es {1}, \n Tu edad es {0}", edad, nombre);
            //Console.WriteLine(formato);


            int[,] sodokuDesboard = new int[3, 3] { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };
            String formato;
            for(int i = 0; i < sodokuDesboard.GetLength(0); i++) { 
                formato = String.Format("|{0}|{1}|{2}| \n-------\n", sodokuDesboard[i,0], sodokuDesboard[i,1], sodokuDesboard[i,2]);
                Console.Write(formato);
            }

            /*Agregar un for para que imprima una fila debajo de la otra. Tal que quede un
             formato de tabla. 2mi 12.16*/
        }
    }
}
