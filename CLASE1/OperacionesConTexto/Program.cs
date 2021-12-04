using System;

namespace OperacionesConTexto
{
    class Program
    {
        static void Main(string[] args)
        {
            String textoA = "Hola, como estas?";
            String textoB = "Mal, es Sabado y estoy cursando";
            // \n en un string se interpreta como enter al mostrar en consola.

            //Concadenacion 
            String resultadoConcadenacion = textoA + " " + textoB;
            Console.WriteLine(resultadoConcadenacion);

            //Cantidad de caracteres
            int cantidadDeCaracteres = textoA.Length;
            Console.WriteLine(cantidadDeCaracteres);
        }
    }
}
