using System;

namespace OperacionesDeRelaciones
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 8;

            //Mayor que 
             Boolean MayorQue = a > b; //False porque 5 no es mayor que 8
            Console.WriteLine(MayorQue);

            //Menor e igual que 
            Boolean MenorIgualQue = a <= b;
            Console.WriteLine(MenorIgualQue);

            //Mayor e igual que 
            Boolean MayorIgualQue = a >= b;
            Console.WriteLine(MayorIgualQue);

            //Igualdad
            Boolean sonIguales = a == b;
            // Si son iguales, el resutaldo es true. Cualquier otro caso el resutlado es false.
            
            //Distintos
            Boolean sonDistintos = a != b;
            // Si son distintos, el resultado es true. Solo es falso en el caso que sean iguales.
        }
    }
}
