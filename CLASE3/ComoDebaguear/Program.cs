using System;

namespace ComoDebaguear
{
    class Program
    {
        static void Main(string[] args)
        {
            /*ANTES DE DEBAGUEAR NECESITO INDICAR DONDE DEBE FRENAR CON UN BREAKPOINT*/
            String palabra = "Hola";
            String acumulador = "";
            for (int i = palabra.Length - 1; i >= 0; i--)
            {
                acumulador = acumulador + palabra[i];
            }
            Console.WriteLine(acumulador);
            //2min 1247am
        }    }
}
