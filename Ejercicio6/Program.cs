using System;
using System.Collections.Generic;

namespace Ejercicio6
{
    class Program
    {

        static void WriteAndReadLine(String mensaje, ref String ingreso)
        {
            Console.WriteLine(mensaje);
            ingreso = Console.ReadLine();
            return;
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
             Modificar la funcion WriteAndReadLine tal que recibe dos parametros; el mensaje a mostrar en pantalla y un string por referencia donde guardar el valor ingresado por el usuario.

            Borrar le return y hacer la funcion del tipo void.
            2mi 11.32
             */
            List<String> listaDeNombres = new List<string>();

            //1
            String nombreIngresado = "";
            WriteAndReadLine("Ingrese un nombre", ref nombreIngresado);

            while (nombreIngresado != "exit")
            {

                //2
                listaDeNombres.Add(nombreIngresado);

                //3
                printList(listaDeNombres);

                //1
                WriteAndReadLine("Ingrese un nombre", ref nombreIngresado);

            }
            }
        }
}
