using System;

namespace WhileAndDoWhile
{
    class Program
    {
        static void Main(string[] args)
        {


            //WHILE

            //CORTE DE CONTROL
            Console.WriteLine("Ingrese exit para salir");
            String continuarEjecutando = Console.ReadLine();

            while(continuarEjecutando != "exit")
            {
                Console.WriteLine("Estoy ejecutando algo ...");
                Console.WriteLine("Ingrese exit para salir");
                continuarEjecutando = Console.ReadLine();
            }

            //DOWHILE
            /*String continuarEjecutando2;

            do
            {
                Console.WriteLine("Estoy ejecutando algo ...");
                Console.WriteLine("Ingrese exit para salir");
                continuarEjecutando2 = Console.ReadLine();
            } while (continuarEjecutando2 != "exit");
            */


        }
    }
}
