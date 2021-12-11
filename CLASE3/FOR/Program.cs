using System;

namespace FOR
{
    class Program
    {
        static void Main(string[] args)
        {

            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("Hola" + i);
            }

            /*
             Soluciones para que haga 5 vueltas;
            - Cambiar la condicion de < a <= para incluir el 5.
            - Cambiar en la condicion el 5 por 6.
            - Cambiar en el valor inicail de 1 a 0.
             */

            //For decendente
            for (int i = 5; i >= 1; i--)
            {
                Console.WriteLine("Hola" + i);
            }

            //Para dar saltos mas grandes
            for(int i = 0; i <= 10; i = i + 3)
            {
                Console.WriteLine(i);
            }
        }
    }
}
