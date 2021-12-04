using System;

namespace OperacionesConVariablesNumericas
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;

            //Suma
            int resultadoSuma = a + b;
            Console.WriteLine(resultadoSuma);
            Console.WriteLine(a + b); /*Esto es una mala practica porque 
                                       * no queda el resultado guardado 
                                       * en ninguna variable por lo que no 
                                       * lo puedo utilizar despues.*/
            //Resta
            int resultadoResta = a - b;
            //Multiplicacion
            int resultadoMultiplicacion = a * b;
            //Division
            int resultadoDivision = a / b;
            //Resto
            int resutladoResto = b % a;
            Console.WriteLine(resutladoResto);
        }
    }
}
