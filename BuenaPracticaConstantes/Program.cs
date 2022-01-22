using System;

namespace BuenaPracticaConstantes
{
    class Program
    {
        static void Main(string[] args)
        {
            const double pi = 3.1415;

            //pi = 2323.23; //-> Tira error porque no le puedo reasignar el valor a una constate.
            const String MENSAJE_NUMERO_1 = "Hello World";
            Console.WriteLine(MENSAJE_NUMERO_1);
        }
    }
}
