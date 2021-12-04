using System;

namespace ConvertFuncion
{
    class Program
    {
        static void Main(string[] args)
        {
            //ReadLine siempre me dueve un valor del tipo STRING
            String texto = Console.ReadLine();
            int valorConvertido = Convert.ToInt32(texto);
            int resultado = 2 + valorConvertido;
            Console.WriteLine(resultado);
           
            //Una excepcion - Cuando el resultado es un string si lo resulve solo
            String concadenacion = "resultado : " + resultado;
            Console.WriteLine(concadenacion);

            //MALA PRACTICA - Dificil de leer y de escalar.
            int valorConvertidoMal = Convert.ToInt32(Console.ReadLine());
        }
    }
}
