using System;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Ejercicio 2 - Parte 1
             * Solicitar al usuario por conosla su nombre y mostrar por pantalla 
             * el mensaje "Hola, NOMBRE INGRESADO".
             * 2MIN 11.02
             */
            Console.WriteLine("Ingres su nombre: ");
            String username = Console.ReadLine();
            String mensaje = "Hola, " + username + "!";
            Console.WriteLine(mensaje);

            /*
             * Ejercicio 2 - Parte 2
             * Solicitar al usuario su nombre (utilizar el nombre ingresado en la parte 1) y la edad, para 
             * mostrar en pantalla el mensaje "Hola, NOMBRE, y tu edad es EDAD".
             * 2min 11.10Am
             */
            Console.WriteLine("Ingrese su edad; ");
            String userage = Console.ReadLine();
            String mensajeDos = "Hola, " + username + ", y tu edad es " + userage;
            Console.WriteLine(mensajeDos);

        }
    }
}
