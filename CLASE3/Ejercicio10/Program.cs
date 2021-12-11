using System;

namespace Ejercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Ejercicio10
             * Crear un programa que dado un string acumule todas las letras por 2.
             * Ejemplo
             * "hola" -> "hhoollaa"
             * 2min 12.09AM
             */
            String palabra = "hola";
            String acumulador = "";
            for(int i = 0; i < palabra.Length; i++)
            {
                acumulador = acumulador + palabra[i] + palabra[i];
            }
            Console.WriteLine(acumulador);
        }
    }
}
