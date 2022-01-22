using System;
using System.Collections.Generic;

namespace Lista
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] array = new int[23];
            

            List<int> lista = new List<int>();
            lista.Add(23);
            lista.Add(44);
            
            //Count es como length, te devuelve la cantidad de elementos de la lista.
            for(int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine(lista[i]);
            }

            List<String> listaDeNombre = new List<string>();
            listaDeNombre.Add("Matias");
            listaDeNombre.Add("Cristian");
            listaDeNombre.Add("Facundo");



        }
    }
}
