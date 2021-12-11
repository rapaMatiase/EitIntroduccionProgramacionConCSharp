using System;

namespace RespasoClaseAnterior
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * ¿Que vimos las semana pasada?
             * ESTRUCTURAS DE CONTROL CONDICIONAL : 
             * IF, I
             * F-ELSE, 
             * IF-ELSE-IF o IF ENCADENADO,
             * IF-ANIDADO
             * 
             * ¿Que nos falto?
             * SWITCH
             * 
             * 
             */
            
            Console.WriteLine("Ingrese un numero");
            String numeroIngresado = Console.ReadLine();
            int numeroConvertido = Convert.ToInt32(numeroIngresado);

             if(numeroConvertido < 0)
            {
                Console.WriteLine("Es negativo");
            }
             else if( numeroConvertido > 0)
            {
                Console.WriteLine("Es positivo");
            }
             else if(numeroConvertido == 0) //DECLARATIVO QUE QUIERIO QUE LO SIGUIENTE OCURRA SI ES IGUAL A 0
            {
                Console.WriteLine("No tiene signo");
            }
            else //CASO POR DEFUALT : SI TODO LO OTRO FALLA, VENGO ACA
            {
                Console.WriteLine("Fallo todo, que hacemos?");
            }
        }
    }
}
