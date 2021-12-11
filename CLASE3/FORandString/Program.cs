using System;

namespace FORandString
{
    class Program
    {
        static void Main(string[] args)
        {
            String palabra = "Hola";
            for(int i = 0; i < palabra.Length; i++)
            {
                Console.WriteLine(palabra[i]);
            }
            /* CIUDADO CON LA CONDICION, SIMPRE MENOR < , NUNCA IGUAL <=.*/

            String acumulador = "";
            //Elemento neutro para la suma es 0, poruqe 0 + 0 + ... + 0 = 0
            //Elemenot neutro para la concadenacion es "" + "" + ... + "" = ""

            for(int i = palabra.Length -1 ; i >= 0; i--)
            {
                acumulador = acumulador + palabra[i];
            }
            Console.WriteLine(acumulador);
        }
    }
}
