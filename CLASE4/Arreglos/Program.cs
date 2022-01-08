using System;

namespace Arreglos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crear un arreglo del tipo numero entero e ininicializarlo como un arreglo con 3 posiciones.
            int[] arreglo = new int[3];

            //Para acceder a los espacios es por medio del numero de la posicon.
            arreglo[0] = 3;
            arreglo[1] = 9;
            arreglo[2] = 5;
            //arreglo[3] = 6; Si intento sobrepasar la poscion maxima de mi array me tira una excepcion que outRange lo que significa que trate de leer memoria que no me correspondia.
            
            //Console.WriteLine(arreglo[0]);
            //Console.WriteLine(arreglo[1]);
            //Console.WriteLine(arreglo[2]);

            //.Length me trae la cantidad de posicion que hay.
            for(int i = 0; i < arreglo.Length; i++)
            {
                Console.WriteLine(arreglo[i]);
            }

            //La ultima posicion del array = cantidad posiciones - 1
            //Sinedo la cantidad de posiciones lo que devuelve el Legth
            // Para este array 2 = 3 - 1
        }
    }
}
