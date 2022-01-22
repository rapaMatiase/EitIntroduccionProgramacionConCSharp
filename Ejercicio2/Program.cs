using System;
using System.Collections.Generic;
namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Realizar un programa que;
            1) Solicite al usuario un nombre
            2) lo agregue a una lista de nombres
            3) Imprima en pantalla el estado del listado en ese momento
            4) Repetir los otros tres pasos, hasta que el usuario ingrese la palbra "exit".
            2min   10.34    */

            List<String> listaDeNombres = new List<string>();

            //1
            Console.WriteLine("Ingrese un nombre");
            String nombreIngresado = Console.ReadLine();

            while (nombreIngresado != "exit"){                 
                
                //2
                listaDeNombres.Add(nombreIngresado);
            
                //3
                String texto = string.Join(", ", listaDeNombres);
                Console.WriteLine(texto);

                //1
                Console.WriteLine("Ingrese un nombre");
                nombreIngresado = Console.ReadLine();

            }

        }
    }
}
