using System;

namespace Sodoku_2
{
    class Program
    {
        const int VALOR_VACIO = 0;
        static int?[,] sodokuDesboard = new int?[3, 3] {
                { VALOR_VACIO, VALOR_VACIO, VALOR_VACIO },
                { VALOR_VACIO, VALOR_VACIO, VALOR_VACIO },
                { VALOR_VACIO, VALOR_VACIO, VALOR_VACIO }
            };
        static Boolean yaGanoElJuego = false;

        /*
         PARTE 1
         Leer e identificar que codigo se podria convertir en una funcion.
        2min 12.02
        - Una funcion para ingresar una coordenda (mostrar el mensaje por pantalla, pedir le ingreso y convertir a numero)
        - Una funcion que controle si la posicion de la matrix a jugar se le suma 1 o vuelve a ser igual a 1.
        - Una funcion que devuelva true o false dependiendo de si hay o no repetidos en las filas.
        - Una funcion igual a la anteriro pero para las columnas.
         */

        /*
         PARTE 2
        Crear y remplazar el codigo correspondiente a las dos primeras funciones de la lista. 3min 12.07
         */
        /*
        PARTE 3
       Crear y remplazar el codigo correspondiente a las dos segundas funciones de la lista. 3min 12.14
        */

        /*
         PARTE 4 - OTRAS BUENAS PRACTICAS CON LAS FUNCIONES

        Utilizar funciones para hacer los IF o WHILES mass declarativos al remplazar la condicion logica por una funcion con la condicion logica adentro. 
         */


        static int SolicitarCoordenda(String mensaje)
        {
            Console.WriteLine(mensaje);
            String coordIngresada = Console.ReadLine();
            int coord = Convert.ToInt32(coordIngresada);
            return coord;

        }

        static void AddToCoord(int i, int j)
        {
            if (sodokuDesboard[i, j] == 3)
            {
                sodokuDesboard[i, j] = 1;
            }
            else
            {
                sodokuDesboard[i, j]++;
            }
        }

        static void ShowTablero()
        {
            String formato;
            for (int i = 0; i < sodokuDesboard.GetLength(0); i++)
            {
                formato = String.Format("|{0}|{1}|{2}| \n-------\n", sodokuDesboard[i, 0], sodokuDesboard[i, 1], sodokuDesboard[i, 2]);
                Console.Write(formato);
            }
        }

        static Boolean HayAlgunRepetidoEnEstaFila(int fila)
        {
            /*
             * Dadi que devolvemos un true cuando la condicion logica es verdadera, y un false cuando la condicion logica es false. Podemos simplificar la funcion devolviendo el resultado de la condicion logica directamente.
             * if(sodokuDesboard[fila, 0] != sodokuDesboard[fila, 1] && sodokuDesboard[fila, 0] != sodokuDesboard[fila, 2] && sodokuDesboard[fila, 1] != sodokuDesboard[fila, 2])
            {
                return true;
            }
            else
            {
                return false;
            }*/
            return sodokuDesboard[fila, 0] != sodokuDesboard[fila, 1] && sodokuDesboard[fila, 0] != sodokuDesboard[fila, 2] && sodokuDesboard[fila, 1] != sodokuDesboard[fila, 2];
        }

        /*PASO 5 - Crear una funcion para remplazar la parte de la condicion logica del if para controlar si hay alguna casilla con valor igual a vacio. 2min 12.30.*/

        static Boolean hayAlgunaCasillaVaciaEnLaFila(int fila)
        {
            return sodokuDesboard[fila, 0] != VALOR_VACIO &&  sodokuDesboard[fila, 1] != VALOR_VACIO && sodokuDesboard[fila, 2] != VALOR_VACIO;
        }

        static Boolean HayRepetidosEnLasFilas()
        {
            //Contrlar las filas
            Boolean banderaTodasLasFilasSonDistintas = true;
            for (int i = 0; i < sodokuDesboard.GetLength(0); i++)
            {
                if (HayAlgunRepetidoEnEstaFila(i) &&  hayAlgunaCasillaVaciaEnLaFila(i))
                {
                    continue;
                }
                else
                {
                    banderaTodasLasFilasSonDistintas = false;
                }
            }
            return banderaTodasLasFilasSonDistintas;
        }

        /* PASO 6 - Hacer un par de funciones para remplazar en el if de repetidos en la columna como se hizo para las filas. 3min 12.35*/
        static Boolean hayRepetidosEnEstaColumna(int columna)
        {
            return sodokuDesboard[0, columna] != sodokuDesboard[1, columna] && sodokuDesboard[0, columna] != sodokuDesboard[2, columna] && sodokuDesboard[1, columna] != sodokuDesboard[2, columna];
        }
        static Boolean hayAlgunaCasillaVaciaEnLaColmna(int columna)
        {
            return sodokuDesboard[0, columna] != VALOR_VACIO && sodokuDesboard[1, columna] != VALOR_VACIO && sodokuDesboard[2, columna] != VALOR_VACIO;
        }
        static Boolean HayRepetidosEnLasColumnas()
        {
            Boolean banderaTodasLasColumnasSonDistintas = true;
            for (int j = 0; j < sodokuDesboard.GetLength(0); j++)
            {
                if (hayRepetidosEnEstaColumna(j) && hayAlgunaCasillaVaciaEnLaColmna(j))
                {
                    continue;
                }
                else
                {
                    banderaTodasLasColumnasSonDistintas = false;
                }
            }
            return banderaTodasLasColumnasSonDistintas;
        }

        static void Main(string[] args)
        {
            int coordI, coordJ;
          
            do
            {
                /* DEBO SOLICITAR LA COORDENADA DONDE JUGAR*/
                coordI = SolicitarCoordenda("Ingrese coordenda I");
                coordJ = SolicitarCoordenda("Ingrese coordenda J");

                //AHORA PUEDO JUGAR
                AddToCoord(coordI, coordJ);

                //MOSTRAMOS EL TABLERO DE JUEGO
                ShowTablero();

                //CONTROLAR SI YA GANO EL JUEGO!?!!
                Boolean banderaTodasLasFilasSonDistintas = HayRepetidosEnLasFilas();

                //Controlar las columnas
                Boolean banderaTodasLasColumnasSonDistintas = HayRepetidosEnLasColumnas();

                //Determinar si ambas cumplen simultaneamente.
                yaGanoElJuego = banderaTodasLasFilasSonDistintas == true && banderaTodasLasColumnasSonDistintas == true;

                if (yaGanoElJuego == true)
                {
                    Console.WriteLine("GANASTE, ");
                }

            } while (!yaGanoElJuego == true);
        }
    }
}
