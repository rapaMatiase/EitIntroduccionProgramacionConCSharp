using System;

namespace VariablesGlobales
{
    class Program
    {
        static String soyUnTextoGlobal = "Globalisame";

        static void prueba()
        {
            Console.WriteLine(soyUnTextoGlobal);
            soyUnTextoGlobal = "error";
        }
        static void Main(string[] args)
        {
            prueba();
            Console.WriteLine(soyUnTextoGlobal);
        }
    }
}
