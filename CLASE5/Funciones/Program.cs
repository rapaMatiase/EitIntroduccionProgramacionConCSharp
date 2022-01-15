using System;

namespace Funciones
{
    class Program
    {

        /*
         static (TIPO DE RETORNO) (NOMBRE DE LA FUNCION) (LOS PARAMETROS){
                //SEGMENTO DE CODIGO A EJECUTAR
            

                RETURN (VALOR A RETRONAR);
            }
         */

        static int Sumar(int a, int b)
        {
            int suma = a + b;
            return suma;
        }

        static void Main(string[] args)
        {
            int resultado = Sumar(2, 4);
            Console.WriteLine(resultado);
        }
    }
}
