using System;

namespace Ejercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            /*EJERCICIO 13
             * Copiar el codigo del ejercicio 12 y trasformar el if en switch.
             * 2min 12.33AM
             */
            String texto = "Fue por culpa del mal tiempo que quedó al descubierto una de las primeras logias masónicas de Buenos Aires de las que se tiene registro. Databa de 1805, se denominaba “San Juan de Jerusalén, de la felicidad de esta parte de la América”, y había sido fundada por el portugués Juan Silva Cordeiro. El tesorero era Manuel Arroyo Pinedo y Juan Angel Vallejos oficiaba de secretario.";
            String acumulador = "";
            for (int i = 0; i < texto.Length; i++)
            {
                Char letra = texto[i];
                switch (letra)
                {
                    case 'a':
                        acumulador = acumulador + 'z';
                        break;
                    case 'e':
                        acumulador = acumulador + 'a';
                        break;
                    case 'i':
                        acumulador = acumulador + 'o';
                        break;
                    default:
                        acumulador = acumulador + letra;
                        break;
                }
            }
            Console.WriteLine(acumulador);
        }
    }
}
