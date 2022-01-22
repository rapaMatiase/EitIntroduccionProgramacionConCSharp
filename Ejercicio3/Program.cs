using System;
using System.Collections.Generic;
namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Realizar un programa que;
            1) Solicite al usuario ingresar un numero
            2) Guardar en una lista. (Recordar qen convertir a valor int)
            3) Imprmir en pantalla el resultado del promedio de los valores de la lista.
            4) Repetir los 3 pasos anteriores hasta que el usuario ingrese 0.
            3min 10.42
             */

            List<int> listaDeNumeros = new List<int>();
            int promedio = 0;
            //1
            Console.WriteLine("Ingrese un numero");
            String numeroIngresado = Console.ReadLine();
            int numeroConvertido = Convert.ToInt32(numeroIngresado);

            while(numeroConvertido != 0) { 
                //2
                listaDeNumeros.Add(numeroConvertido);

                int sumatoria = 0;
                for(int i = 0; i < listaDeNumeros.Count; i++)
                {
                    sumatoria += listaDeNumeros[i];
                }

                promedio = sumatoria / listaDeNumeros.Count;

                Console.WriteLine("El promedio es " + promedio);

                //1
                Console.WriteLine("Ingrese un numero");
                numeroIngresado = Console.ReadLine();
                numeroConvertido = Convert.ToInt32(numeroIngresado);

            }
        }
    }
}
