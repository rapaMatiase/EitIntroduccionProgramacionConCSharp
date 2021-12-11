using System;

namespace Ejercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Ejercicio11
             * Dado un string, acumular en otro string todo el texto, excepto las letras 'a' y 'e'.
             * "filtrar las letras a y e "
             * 2min 12.15AM
             * for con if anidado andentro.
             */
            String texto = "Fue por culpa del mal tiempo que quedó al descubierto una de las primeras logias masónicas de Buenos Aires de las que se tiene registro. Databa de 1805, se denominaba “San Juan de Jerusalén, de la felicidad de esta parte de la América”, y había sido fundada por el portugués Juan Silva Cordeiro. El tesorero era Manuel Arroyo Pinedo y Juan Angel Vallejos oficiaba de secretario.";
            String acumulador = "";
            for (int i = 0; i < texto.Length; i++)
            {
                if(texto[i] != 'a' && texto[i] != 'e')
                {
                    acumulador = acumulador + texto[i];
                }
            }
            Console.WriteLine(acumulador);
        }
    }
}
