using System;
using System.Collections.Generic;
namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Crear un programa que ;
            1) solicite al usuario ingresar un nombre por consola.
            2) agregar este nombre a una lista de string.
            3) Imprmir la lista en pantalla utilizando un for.
            2min 10.26
             */
            
            List<String> listaDeNombres = new List<string>();
            //1
            Console.WriteLine("Ingrese un nombre");
            String nombreIngresado = Console.ReadLine();
            //2
            listaDeNombres.Add(nombreIngresado);
            //3 - Una forma
            /*
            for(int i = 0; i < listaDeNombres.Count; i++)
            {
                Console.WriteLine(listaDeNombres[i]);
            }
            */

            String texto = string.Join(", ", listaDeNombres);
            Console.WriteLine(texto);

        }
    }
}
