using System;

namespace OperacionesConString
{
    class Program
    {
        static void Main(string[] args)
        {
            String nombre = "Matias";
            String apellido = "Rapa";

            //Concadenacion
            String concadenacion = nombre + apellido;
            Console.WriteLine(concadenacion);

            //Cantidad de caracteres
            int cantidadDeCaracteres = nombre.Length;
            Console.WriteLine(cantidadDeCaracteres);
        }
    }
}
