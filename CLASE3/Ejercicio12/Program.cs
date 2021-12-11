using System;

namespace Ejercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            /*EJERCICIO 12
             * Dado el mismo texto que el ejercicio anterio. Donde hay una 'a' remplazar por una 'z'
             * , donde hay una 'e' remplazar por 'a' y donde hay una 'i' remplazar por una 'o'.
             * 3 min 12.22AM
             */

            String texto = "Fue por culpa del mal tiempo que quedó al descubierto una de las primeras logias masónicas de Buenos Aires de las que se tiene registro. Databa de 1805, se denominaba “San Juan de Jerusalén, de la felicidad de esta parte de la América”, y había sido fundada por el portugués Juan Silva Cordeiro. El tesorero era Manuel Arroyo Pinedo y Juan Angel Vallejos oficiaba de secretario.";
            String acumulador = "";
            for(int i = 0; i < texto.Length; i++)
            {
                Char letra = texto[i];
                if(letra == 'a')
                {
                    acumulador = acumulador + 'z';
                } 
                else if (letra == 'e')
                {
                    acumulador = acumulador + 'a';
                }
                else if (letra == 'i')
                {
                    acumulador = acumulador + 'o';
                }
                else
                {
                    acumulador = acumulador + letra;
                }
            }
            Console.WriteLine(acumulador);
        }
    }
}
