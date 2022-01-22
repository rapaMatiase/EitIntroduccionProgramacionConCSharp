using System;
using System.Collections.Generic;
namespace Ejercicio4
{
    class Program
    {

        static String WriteAndReadLine(String mensaje)
        {
            Console.WriteLine(mensaje);
            String ingreso = Console.ReadLine();
            return ingreso;
        }

        static void printList(List<String> lista)
        {
            String listaEnString = string.Join(", ", lista);
            Console.WriteLine(listaEnString);
            return;
        }
        static void Main(string[] args)
        {
            /*
             PARTE 1
             Analice el codigo del ejercio 2 y determine que funciones se podria dividir el programa.
            2min 10.55
             */

            /*
             PARTE 2
            Crear una funcion para;
            1) El ingreso de un valor por pantalla con el mensjae incluido. Debera devolver el valor ingresado.
            2)El imrimir el listado en pantalla.
            3min 10.59AM
             */

            /*
             PARTE 3
            Utilizando las funciones refactorizar el codigo del ejericico 2.

            2min 11.03
             */

            List<String> listaDeNombres = new List<string>();

            //1
            String nombreIngresado = WriteAndReadLine("Ingrese un nombre");

            while (nombreIngresado != "exit")
            {

                //2
                listaDeNombres.Add(nombreIngresado);

                //3
                printList(listaDeNombres);

                //1
                nombreIngresado = WriteAndReadLine("Ingrese un nombre");

            }
        }
    }
}
