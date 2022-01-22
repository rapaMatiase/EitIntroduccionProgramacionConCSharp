using System;

namespace Sodoku
{
    class Program
    {
        static void Main(string[] args)
        {
            const int VALOR_VACIO = 0;
            //Nosostros determinamos que 0 es el valor que representa que una casilla esta vacia
            int?[,] sodokuDesboard = new int?[3, 3] { 
                { VALOR_VACIO, VALOR_VACIO, VALOR_VACIO }, 
                { VALOR_VACIO, VALOR_VACIO, VALOR_VACIO }, 
                { VALOR_VACIO, VALOR_VACIO, VALOR_VACIO } 
            };
            String coordIngresadaI, coordIngresadaJ;
            int coordI, coordJ;
            String formato;
            Boolean yaGanoElJuego = false;

            do
            {
                /* DEBO SOLICITAR LA COORDENADA DONDE JUGAR*/
                coordIngresadaI = Console.ReadLine();
                coordI = Convert.ToInt32(coordIngresadaI);

                coordIngresadaJ = Console.ReadLine();
                coordJ = Convert.ToInt32(coordIngresadaJ);

                //AHORA PUEDO JUGAR
                if(sodokuDesboard[coordI, coordJ] == 3)
                {
                    sodokuDesboard[coordI, coordJ] = 1;
                }
                else
                {
                    sodokuDesboard[coordI, coordJ]++;
                }

                //MOSTRAMOS EL TABLERO DE JUEGO
                for (int i = 0; i < sodokuDesboard.GetLength(0); i++)
                {
                    formato = String.Format("|{0}|{1}|{2}| \n-------\n", sodokuDesboard[i, 0], sodokuDesboard[i, 1], sodokuDesboard[i, 2]);
                    Console.Write(formato);
                }

                //CONTROLAR SI YA GANO EL JUEGO!?!!

                //Contrlar las filas
                Boolean banderaTodasLasFilasSonDistintas = true;
                for (int i = 0; i < sodokuDesboard.GetLength(0); i++)
                {
                    if (sodokuDesboard[i, 0] != sodokuDesboard[i, 1] && sodokuDesboard[i, 0] != sodokuDesboard[i, 2] && sodokuDesboard[i, 1] != sodokuDesboard[i, 2] && sodokuDesboard[i, 0] != VALOR_VACIO && sodokuDesboard[i, 1] != VALOR_VACIO && sodokuDesboard[i, 2] != VALOR_VACIO)
                    {
                        continue;
                    }
                    else
                    {
                        banderaTodasLasFilasSonDistintas = false;
                    }
                }

                //Controlar las columnas
                Boolean banderaTodasLasColumnasSonDistintas = true;
                for (int j = 0; j < sodokuDesboard.GetLength(0); j++)
                {
                    if (sodokuDesboard[0, j] != sodokuDesboard[1, j] && sodokuDesboard[0, j] != sodokuDesboard[2, j] && sodokuDesboard[1, j] != sodokuDesboard[2, j] && sodokuDesboard[0, j] != VALOR_VACIO  && sodokuDesboard[1, j] != VALOR_VACIO && sodokuDesboard[2, j] != VALOR_VACIO)
                    {
                        continue;
                    }
                    else
                    {
                        banderaTodasLasColumnasSonDistintas = false;
                    }
                }

                //Determinar si ambas cumplen simultaneamente.
                yaGanoElJuego = banderaTodasLasFilasSonDistintas == true && banderaTodasLasColumnasSonDistintas == true;

                if(yaGanoElJuego == true)
                {
                    Console.WriteLine("GANASTE, ");
                }

            } while (!yaGanoElJuego == true);
        }
    }
}
