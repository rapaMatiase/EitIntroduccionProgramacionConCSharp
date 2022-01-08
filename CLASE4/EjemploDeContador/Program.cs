using System;

namespace EjemploDeContador
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             EJEMPLO PARTE 1
             Dado un array contar cuantas veces aparece un elemento en este.
             */
            
            /*int[] array = new int[6] { 1, 3, 2, 2, 1, 3 };

            int? elementoContar = null;
            int contador = 0;
            for(int i =0; i < array.Length; i++)
            {
                //Tomo un numero del array para contar
                elementoContar = array[i]; 
                for(int c = 0; c < array.Length; c++)
                {
                    if(array[c] == elementoContar)
                    {
                        contador++;
                    }
                }
                Console.WriteLine(elementoContar + " Aparece " + contador);
                //Volvemos a inicializar en 0 al contador para el proximo numero.
                contador = 0;
            }
            */
            /*
             EJEMPLO PARTE 2
             Dado un array contar cuantas veces aparece un elemento en este.
             No contar dos veces el mismo elemento.
             */

            int[] array = new int[6] { 1, 3, 2, 2, 1, 3 };

            int? elementoContar = null;
            int contador = 0;
            int?[] losYaContados = new int?[6];
            int ultimaPosicionUtilizada = 0;
            for (int i = 0; i < array.Length; i++)
            {
                //Tomo un numero del array para contar
                elementoContar = array[i];

                //PRIMERO CONTROLO SI LO CONTE
                Boolean noEstaContado = true;
                for(int x = 0; x < losYaContados.Length; x++)
                {
                    if(losYaContados[x] == elementoContar)
                    {
                        noEstaContado = false;
                    }
                }

                //SEGUNDO VOY CUENTO

                if (noEstaContado) {
                    //Guado el elemento por contar, para ya saber que lo conte
                    losYaContados[ultimaPosicionUtilizada] = elementoContar;
                    ultimaPosicionUtilizada++;

                    for (int c = 0; c < array.Length; c++)
                    {
                        if (array[c] == elementoContar)
                        {
                            contador++;
                        }
                    }
                    Console.WriteLine(elementoContar + " Aparece " + contador);
                    //Volvemos a inicializar en 0 al contador para el proximo numero.
                    contador = 0;
                }
            }

            
        }
    }
}
