using System;

namespace Ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Ejercicio 7 - Telecom
             * La empresa Telecom nos contrato para su nuevo call center. Debemos gestionar los ingresos del usuario.
             * Los ingresos que puede ocurrir son;
             * - 0 : debe solicictar el ingreso del DNI del usaurio.
             * - 1 : debe solicitar el nombre al usuario.
             * - 2 : debe solicitar el numero de cliente. 
             * 
             * En cada caso solicitar el ingreo del dato y luego volver a mostra en pantalla. 
             * 3 min 12.52
             */

            String  dni = "", nombre = "", numeroDeCliente = "";

            Console.WriteLine("Ingrese una opcion : 0, 1, 2");
            String opcion = Console.ReadLine();

            if (opcion == "0")
            {
                Console.WriteLine("Ingrese su dni;");
                dni = Console.ReadLine();
            }
            else if (opcion == "1")
            {
                Console.WriteLine("Ingrese su nombre;");
                nombre = Console.ReadLine();
            }
            else if (opcion == "2")
            {
                Console.WriteLine("Ingrese su numero de cliente;");
                numeroDeCliente = Console.ReadLine();
            }

            Console.WriteLine(dni);
        }
    }
}
