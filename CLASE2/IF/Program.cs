using System;

namespace IF
{
    class Program
    {
        static void Main(string[] args)
        {
            //Solicito la edad
            string edad = Console.ReadLine();
            //Convertirla
            int edadConvertida = Convert.ToInt32(edad);

            //Argentina se puede sacar el registr con 18 o mas años.
            //if (cond.logcia) {
            //    La accion a realizar si esta condicion logica fue verdadera
            //}

            if(edadConvertida >= 18){
                Console.WriteLine("Podes sacar el registro");
            }

        }
    }
}
