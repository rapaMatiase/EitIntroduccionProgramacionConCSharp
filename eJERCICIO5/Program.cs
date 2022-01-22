using System;
using System.Collections.Generic;
namespace eJERCICIO5
{
    class Program
    {

        static void AgregarElemento(List<String> listaDeNombres2)
        {
            Console.WriteLine("Ingrese un nombre");
            String nombreIngresador = Console.ReadLine();
            listaDeNombres2.Add(nombreIngresador);
        }


        static void Main(string[] args)
        {
            /*
             Dada una lista de nombres, crear una funcion que recibe la lista como parametro, pero no devuelve ningun valor. Esta funcion debe solicitar al usuario que ingrese un nombre y luego agregarlo a la lista.

            Al final del programa, despues de haber invocado la funcion, imprimir la lisa en pantalla.

            ¿El resutlado es le esperado?
            2min 11.20
             */
            List<String> listaDeNombres = new List<string>();
            AgregarElemento(listaDeNombres);

            String listaEnTexto = string.Join(", ", listaDeNombres);
            Console.WriteLine(listaEnTexto);
        }
    }
}
