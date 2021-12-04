using System;

namespace TipoDeVariablesNumericas
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Buenas practicas nombre de las variables (son opcionales):
                
                - Uso de notacion para lectura facil.
                [x] camelCase -> Todas las palabras arrancan con mayuscula excepto la primera palabra.
                    PascalCase -> Todas las palabras arrancan con mayuscula.
                    keb-case -> Utilizamos un - entre palabras.
                    snake_case -> Utilizamos un _ entre plabras.

                - Usar nombres declarativos (Es facil interpretar el valor guardado en esa variable)
                    Por ejemplo quiero guardar la edad de un usuario,
                        Nombres declarativos : edadDeUsuario, userAge, edadUsuario.
                        Nombres no declarativos : edad, eu, usera, a, b. 

                Reglas (no son opcionales):
                - Los nombres no pueden llevar; espacios, caracteres especiales excepto _.
                    Ejemplos no validos de nombre: &nombre, n"ombre, nombre de usuario.
                - No pueden arrancar con numeros. 
                    Ejemplo no validos : 1usuario, 2usuario.
                    Ejemplo validos: usuario1, u1suario, usuario2, ....

             */

            //Las variables de tipo numerico.

            // PALABRA RESERVADA QUE DENOTA EL TIPO + NOMBRE DE LA VARIABLE = EL VALOR A GUARDAR EN MEMORIA

            // Tipos numerico para enteros.
            byte numeroEnterosPositivo0a255 = 100;
            uint numeroEnteroPositivo = 1000;
            int numerosEntero = -2332;

            Console.WriteLine(numeroEnterosPositivo0a255);

            //Tipos flotantes o con coma. Hasta 7 de representacion despues de la coma.
            float NumeroConComaMasChico = 3.3322232343443432342342353f;
            double NumeroConComaDelMedio = 3.3322232343443432342342353;
            decimal NumeroConComaElMasGrande = 3.3322232343443432342342353444444M;

            Console.WriteLine("Flotante ___");
            Console.WriteLine(NumeroConComaMasChico);
            Console.WriteLine("Double ___");
            Console.WriteLine(NumeroConComaDelMedio);
            Console.WriteLine("Decimal ___");
            Console.WriteLine(NumeroConComaElMasGrande);

        }

    }
}
